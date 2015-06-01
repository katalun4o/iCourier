using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.LightSwitch;

namespace LightSwitchApplication.PrintTemplates.FIS
{
    public partial class FisPrint : DevExpress.XtraReports.UI.LightSwitchReport
    {
        public FisPrint()
        {
            InitializeComponent();
        }

        private void FisPrint_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void FisPrint_DataSourceDemanded(object sender, EventArgs e)
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

        private void xrLabel34_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VouchersView v = (VouchersView)GetCurrentRow();
            if (v == null)
                return;

            ((XRLabel)sender).Text = v.c_Date.Day + "/" + v.c_Date.Month + "/" + v.c_Date.Year;
        }

        private void xrLabelAddress_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //receiver address + street number
            VouchersView v = (VouchersView)GetCurrentRow();
            if (v == null)
                return;
            //((XRLabel)sender).Text = v.ReceiverAddress + " - " + v.ReceiverStreetNum;

            string linker = " - ";
            if (string.IsNullOrEmpty(v.ReceiverAddress) || string.IsNullOrEmpty(v.ReceiverStreetNum))
                linker = "";
            ((XRLabel)sender).Text = string.Format("{0}{1}{2}", v.ReceiverAddress, linker, v.ReceiverStreetNum).Trim();
        }

        private void xrLabelArea_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //receiver area + post code
            VouchersView v = (VouchersView)GetCurrentRow();
            if (v == null)
                return;
            string linker = " - ";
            if (string.IsNullOrEmpty(v.ReceiverArea) || string.IsNullOrEmpty(v.ReceiverPK))
                linker = "";
            ((XRLabel)sender).Text = string.Format("{0}{1}{2}", v.ReceiverArea, linker, v.ReceiverPK).Trim();
        }

        private void xrLabelMemo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //delivery hours + memo
            VouchersView v = (VouchersView)GetCurrentRow();
            if (v == null)
                return;
            string text = "";
            if (v.DeliveryHourFrom == null && v.DeliveryHourFrom == null)
                text = v.Memo;
            else
            {
                string linker = " - ";
                if (v.DeliveryHourFrom == null || v.DeliveryHourTo == null)
                    linker = "";

                string df = v.DeliveryHourFrom == null ? "" : v.DeliveryHourFrom.Value.ToString("HH:mm");
                string dt = v.DeliveryHourTo == null ? "" : v.DeliveryHourTo.Value.ToString("HH:mm");

                text = string.Format("({0}{1}{2}) {3}", df, linker, dt, v.Memo);
            }
            ((XRLabel)sender).Text = text;
        }

        private void lblRowIndex_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRLabel)sender).Text = CurrentRowIndex.ToString();
        }

    }
}
