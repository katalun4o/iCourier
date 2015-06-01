using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Microsoft.LightSwitch;

namespace LightSwitchApplication
{
    public partial class VoucherReport : DevExpress.XtraReports.UI.LightSwitchReport
    {
        public VoucherReport()
        {
            InitializeComponent();

            /*if (SenderID == 0)
            {
                var res = (from sender in Application.Current.CreateDataWorkspace().CourierAzureData.Senders
                           where sender.Username == Application.Current.User.Name
                           select sender).FirstOrDefault();
                SenderID = res == null ? -1 : res.SenderID;
            }*/
/*            System.Collections.Generic.List<decimal> lstidS = new System.Collections.Generic.List<decimal>() { 249297,
249298,
249299,
249300};
            
            var cData = (from i in Application.Current.CreateDataWorkspace().CourierAzureData1.VouchersViews where lstidS.Contains(i.VoucherID) select i);
            System.Collections.Generic.List<object> obs = new System.Collections.Generic.List<object>();
            foreach(var res in cData)
            {
                obs.Add(res);            
            }
            ((VoucherTemplateReport)xrSubreport1.ReportSource).DataSource = obs;
            ((VoucherTemplateReport)xrSubreport2.ReportSource).DataSource = obs;
            ((VoucherTemplateReport)xrSubreport3.ReportSource).DataSource = obs;*/

            
        }

        string vIDs = "";
        private void VoucherReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            vIDs = "";
           string voucherIDs = (string)Parameters[0].Value;
           System.Collections.Generic.List<decimal> ids = new System.Collections.Generic.List<decimal>();
            foreach(string s in voucherIDs.Split(','))
            {
                ids.Add(decimal.Parse(s));
            }
            ids.Sort();
            foreach(decimal id in ids)
            {
                vIDs += id.ToString() + ",";
            }
            vIDs = vIDs.TrimEnd(',');
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRSubreport)sender).ReportSource.Parameters[0].Value = 0;
            string idsString = vIDs;
            string[] ids = idsString.Split(',');
            int ct = 0;
            string newIDs = "";
            foreach(string id in ids)
            {
                if(ct % 3 == 0)
                {
                    newIDs += id + ","; 
                }
                ct++;
            }
            newIDs = newIDs.TrimEnd(',');
            ((XRSubreport)sender).ReportSource.Parameters[0].Value = newIDs;

            /*if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                decimal senderID = (decimal)Parameters[1].Value;
                if (string.IsNullOrEmpty(voucherIDs) == false)
                    ((XRSubreport)sender).ReportSource.FilterString = " SenderID = " + senderID + " AND VoucherID IN (" + voucherIDs + ")";
                    //((XRSubreport)sender).ReportSource.FilterString = " VoucherID IN (" + voucherIDs + ")";
            }*/
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRSubreport)sender).ReportSource.Parameters[0].Value = 1;
            //((XRSubreport)sender).ReportSource.Parameters[0].Value = Parameters[0].Value;
            string idsString = vIDs;
            string[] ids = idsString.Split(',');
            int ct = 0;
            string newIDs = "";
            foreach (string id in ids)
            {
                if (ct % 3 == 1)
                {
                    newIDs += id + ",";
                }
                ct++;
            }
            newIDs = newIDs.TrimEnd(',');
            ((XRSubreport)sender).ReportSource.Parameters[0].Value = newIDs;
            
            /*if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                decimal senderID = (decimal)Parameters[1].Value;
                if (string.IsNullOrEmpty(voucherIDs) == false)
                    ((XRSubreport)sender).ReportSource.FilterString = " SenderID = " + senderID + " AND VoucherID IN (" + voucherIDs + ")";
                    //((XRSubreport)sender).ReportSource.FilterString = " VoucherID IN (" + voucherIDs + ")";
            }*/
        }

        private void xrSubreport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRSubreport)sender).ReportSource.Parameters[0].Value = 2;
            //((XRSubreport)sender).ReportSource.Parameters[0].Value = Parameters[0].Value;

            string idsString = vIDs;
            string[] ids = idsString.Split(',');
            int ct = 0;
            string newIDs = "";
            foreach (string id in ids)
            {
                if (ct % 3 == 2)
                {
                    newIDs += id + ",";
                }
                ct++;
            }
            newIDs = newIDs.TrimEnd(',');
            ((XRSubreport)sender).ReportSource.Parameters[0].Value = newIDs;

            /*if (this.Parameters.Count > 0)
            {
                string voucherIDs = (string)Parameters[0].Value;
                decimal senderID = (decimal)Parameters[1].Value;
                if (string.IsNullOrEmpty(voucherIDs) == false)
                    ((XRSubreport)sender).ReportSource.FilterString = " SenderID = " + senderID + " AND VoucherID IN (" + voucherIDs + ")";
                    //((XRSubreport)sender).ReportSource.FilterString = " VoucherID IN (" + voucherIDs + ")";
            }*/
        }

        private void VoucherReport_DataSourceDemanded(object sender, EventArgs e)
        {
            
        }

    }
}
