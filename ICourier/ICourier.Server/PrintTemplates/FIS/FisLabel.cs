using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.LightSwitch;

namespace LightSwitchApplication
{
    public partial class FisLabel : DevExpress.XtraReports.UI.LightSwitchReport
    {
        public FisLabel()
        {
            InitializeComponent();
        }

        private void VoucherReportInterpostLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            /*if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                if (string.IsNullOrEmpty(voucherIDs) == false)
                    this.FilterString = " VoucherID IN (" + voucherIDs + ")";
            }*/
        }

        private void lblAddress_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1}", v.Address, v.StreetNum).Trim();
        }

        private void lblPostCodeCity_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1}", v.PK, v.City).Trim();
        }

        private void lblReceiverPhone_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1}", v.ReceiverPhone, v.ReceiverPhone1).Trim();
        }

        private void lblReceiverPostCode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1} {2}", v.ReceiverPK, v.ReceiverCity, v.ReceiverArea).Trim();
        }

        private void xrLabel36_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //receiver address
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1}", v.ReceiverAddress, v.ReceiverStreetNum).Trim();
        }

        private void xrLabel39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = v.c_Date.Day + "/" + v.c_Date.Month + "/" + v.c_Date.Year;
        }

        private void xrLabel20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //payer type
            VouchersView v = (VouchersView)GetCurrentRow();
            //((XRLabel)sender).Text = v.PayerType == 1 ? "ΧΡΕΩΣΗ ΑΠΟΣΤΟΛΕΑ" : "ΧΡΕΩΣΗ ΠΑΡΑΛΗΠΤΗ";
            ((XRLabel)sender).Text = v.PayerType == 1 ? "ΧΑ" : "ΧΠ";
        }

        private void xrLabel14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //package type
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = v.PackageType == 1 ? "ΔΕΜΑ" : "ΦΑΚΕΛΟΣ";
        }

        private void xrLabel21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = v.Memo;
        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = v.Memo1 + " " + v.Memo2;
        }

        private void xrLabel42_EvaluateBinding(object sender, BindingEventArgs e)
        {
            if (e.Value == null)
                e.Value = 0;
        }

        private void xrLabel42_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            //string cashCheckString = v.CashCheck == 1 ? "ΜΕΤΡΗΤΑ" : "ΕΠΙΤΑΓΗ";
            string cashCheckString = v.CashCheck == 2 ? "ΕΠ." : "ΜΕΤΡ.";
            if (v.Antikatavoli == null || v.Antikatavoli == 0)
            {
                ((XRLabel)sender).Text = "0";
                return;
            }
            ((XRLabel)sender).Text = v.Antikatavoli.Value.ToString("##########0.##") + " " + cashCheckString;
        }

        private void VoucherReportInterpostLabel_DataSourceDemanded(object sender, EventArgs e)
        {
            if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                string[] vIDs = voucherIDs.Split(',');
                System.Collections.Generic.List<decimal> lstidS = new System.Collections.Generic.List<decimal>();
                foreach (var id in vIDs)
                {
                    lstidS.Add(decimal.Parse(id));
                }

                var cData = (from i in ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.VouchersViews where lstidS.Contains(i.VoucherID) select i).OrderBy(i=>i.VoucherID);
                System.Collections.Generic.List<object> obs1 = new System.Collections.Generic.List<object>();

                foreach (var res in cData)
                {
                    obs1.Add(res);
                }

                this.DataSource = obs1;
            }
        }

    }
}
