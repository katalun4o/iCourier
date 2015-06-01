using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.LightSwitch;

namespace LightSwitchApplication.Reports
{
    public partial class EReportCustomer : DevExpress.XtraReports.UI.LightSwitchReport
    {
        public EReportCustomer()
        {
            InitializeComponent();


        }

        private void EReportCustomer_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                if (string.IsNullOrEmpty(voucherIDs) == false)
                    this.FilterString = " VoucherID IN (" + voucherIDs + ")";
            }
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //VouchersView v = (VouchersView)GetCurrentRow();
            //((XRLabel)sender).Text = string.Format("{0}, {1} {2}", v.ReceiverArea, v.ReceiverAddress, v.ReceiverStreetNum).Trim();
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //VouchersView v = (VouchersView)GetCurrentRow();
            //((XRLabel)sender).Text = string.Format("{0} {1}", v.Code, v.Name).Trim();
        }

        private void xrLabel15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRLabel)sender).Text = RowCount.ToString();
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //VouchersView v = (VouchersView)GetCurrentRow();
            //((XRLabel)sender).Text = string.Format("{0} {1}", v.ReceiverCode, v.ReceiverName).Trim();
        }

        private void xrLabel17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRLabel)sender).Text = DateTime.Now.ToShortDateString();
            //((XRLabel)sender).Text = DateTime.Now.ToString("dd/MM/yyyy");
            ((XRLabel)sender).Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        }

        private void xrLabel4_EvaluateBinding(object sender, BindingEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            //((XRLabel)sender).Text = string.Format("{0} {1}", v.ReceiverCode, v.ReceiverName).Trim();
            e.Value = string.Format("{0} {1}", v.ReceiverCode, v.ReceiverName).Trim();
        }

        private void xrLabel5_EvaluateBinding(object sender, BindingEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            e.Value = string.Format("{0}, {1} {2}", v.ReceiverArea, v.ReceiverAddress, v.ReceiverStreetNum).Trim();
        }

        private void xrLabel2_EvaluateBinding(object sender, BindingEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            e.Value = string.Format("{0} {1}", v.Code, v.Name).Trim();
        }

        private void EReportCustomer_DataSourceDemanded(object sender, EventArgs e)
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

                var cData = (from i in ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.VouchersViews where lstidS.Contains(i.VoucherID) select i);
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
