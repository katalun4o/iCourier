using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.LightSwitch;

namespace LightSwitchApplication
{
    public partial class VoucherReportCourier4U : DevExpress.XtraReports.UI.LightSwitchReport
    {
        public VoucherReportCourier4U()
        {
            InitializeComponent();
        }

        private void VoucherReportCourier4U_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                if (string.IsNullOrEmpty(voucherIDs) == false)
                    this.FilterString = " VoucherID IN (" + voucherIDs + ")";
            }
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1}", v.Address, v.StreetNum).Trim();
        }

        private void xrLabel16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            ((XRLabel)sender).Text = string.Format("{0} {1}", v.ReceiverAddress, v.ReceiverStreetNum).Trim();
        }

        private void VoucherReportCourier4U_DataSourceDemanded(object sender, EventArgs e)
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
