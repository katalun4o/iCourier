using System;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.LightSwitch;
using System.Collections.Generic;

namespace LightSwitchApplication.PrintTemplates.Delatolas
{
    public partial class DelatolasPrint : DevExpress.XtraReports.UI.XtraReport
    {
        public DelatolasPrint()
        {
            InitializeComponent();

            this.lblPayWayBillOfExchange.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PayWayBillOfExchange", "{0:0.00}")});

            this.lblPayWayCash.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PayWayCash", "{0:0.00}")});

            this.lblPayWayCheck.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "PayWayCheck", "{0:0.00}")});

            //this.lblReceiverCity.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            //new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverCity")});

            this.lblSenderTaxNum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TaxNum")});

            this.lblReceiverTaxNum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReceiverTaxNum")});
            
        }

        private void DelatolasPrint_DataSourceDemanded(object sender, EventArgs e)
        {
            if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                decimal senderId = (decimal)Parameters[1].Value;
                string[] vIDs = voucherIDs.Split(',');
                System.Collections.Generic.List<decimal> lstidS = new System.Collections.Generic.List<decimal>();
                foreach (var id in vIDs)
                {
                    lstidS.Add(decimal.Parse(id));
                }
                                
                var downloadedVouchers = ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.VouchersViews.Where(v => lstidS.Contains(v.VoucherID));
                System.Collections.Generic.List<object> vouchersToPrint = new System.Collections.Generic.List<object>();

                var newSender = ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.Senders.Where(s => s.SenderID == senderId).SingleOrDefault();
                
                decimal currentLastSecondaryId = newSender.LastSecondaryVoucher ?? (newSender.SecondaryVoucherFrom ?? 0);

                Dictionary<decimal, string> dicNewSecondaryVouchers = new Dictionary<decimal, string>();

                foreach (var downloadedVoucher in downloadedVouchers)
                {
                    VouchersView voucher = (VouchersView)downloadedVoucher;
                    int vouchersCount = Convert.ToInt32(voucher.Count);
                    if (vouchersCount > 1)
                    {
                        List<decimal> secondaryIds = new List<decimal>();

                        if (!string.IsNullOrEmpty(voucher.SecondaryVouchers))
                        {
                            // already printed, use printed numbers

                            string[] secVouchersStrings = voucher.SecondaryVouchers.Split(',');
                            foreach (string secVoucherString in secVouchersStrings)
                            {
                                decimal secVoucher = 0;
                                if(decimal.TryParse(secVoucherString, out secVoucher))
                                {
                                    secondaryIds.Add(secVoucher);
                                }                                
                            }

                        }
                        else
                        {
                            // not printed, generate new numbers
                            dicNewSecondaryVouchers.Add(voucher.VoucherID, "");
                            for (int i = 0; i < vouchersCount - 1; i++)
                            {
                                currentLastSecondaryId++;
                                secondaryIds.Add(currentLastSecondaryId);
                                dicNewSecondaryVouchers[voucher.VoucherID] += currentLastSecondaryId.ToString() + ",";
                            }
                            dicNewSecondaryVouchers[voucher.VoucherID] = dicNewSecondaryVouchers[voucher.VoucherID].TrimEnd(',');
                        }

                        foreach (decimal secondaryId in secondaryIds)
                        {
                            VouchersView newVouchersView = Cloner.Clone(voucher);
                            newVouchersView.Number = secondaryId.ToString();
                            vouchersToPrint.Add(newVouchersView);
                        }
                    }

                    
                    vouchersToPrint.Add(downloadedVoucher);
                }

                ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.Details.DiscardChanges();
                foreach(KeyValuePair<decimal, string> newSecVoucher in dicNewSecondaryVouchers)
                {
                    var voucherToUpdate = ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.Vouchers.Where(v => v.VoucherID == newSecVoucher.Key).SingleOrDefault();
                    if(voucherToUpdate != null)
                    {
                        voucherToUpdate.SecondaryVouchers = newSecVoucher.Value;
                    }
                }
                newSender.LastSecondaryVoucher = currentLastSecondaryId;

                ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.SaveChanges();

                List<object> list = new List<object>();
                list.AddRange(vouchersToPrint.AsEnumerable());
                list.AddRange(vouchersToPrint.AsEnumerable());
                list.AddRange(vouchersToPrint.AsEnumerable());

                this.DataSource = list.OrderBy(o => ((VouchersView)o).Number);
                //this.DataSource = vouchersToPrint;
            }                
        
        }

        private void xrPageBreak1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if(CurrentRowIndex % 3 != 2)
            {
                e.Cancel = true;
            }
        }
        
        private void tickHasPayment_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currentRow = (VouchersView)this.GetCurrentRow();
            e.Cancel = !(currentRow.PayWayCash.HasValue || currentRow.PayWayCheck.HasValue || currentRow.PayWayBillOfExchange.HasValue);
        }

        private void tickHasPaymentCash_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currentRow = (VouchersView)this.GetCurrentRow();
            e.Cancel = !(currentRow.PayWayCash.HasValue);
        }

        private void tickHasPaymentBillOfExchange_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currentRow = (VouchersView)this.GetCurrentRow();
            e.Cancel = !(currentRow.PayWayBillOfExchange.HasValue);
        }

        private void tickHasPaymentCheck_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currentRow = (VouchersView)this.GetCurrentRow();
            e.Cancel = !(currentRow.PayWayCheck.HasValue);
        }
    }
}
