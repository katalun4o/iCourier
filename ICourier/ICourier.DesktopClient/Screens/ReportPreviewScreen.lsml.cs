using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class ReportPreviewScreen
    {
        public const string NormalPrint = "NormalPrint";
        public const string DriverPrint = "DriverPrint";
        public const string LabelPrint = "LabelPrint";

        decimal SenderID = 0;
        // Do not rename the CustomizeReportPreviewModel method because it is used to access the ReportPreviewModel that is associated with this Report Preview Screen.
        // You can remove this method if you do not need to access the ReportPreviewModel.
        public void CustomizeReportPreviewModel(DevExpress.Xpf.Printing.ReportPreviewModel model)
        {
            //if (model.Parameters.Count > 0)
            {
                model.Parameters["VoucherIDs"].Value = SelectedVouchers;
                model.Parameters["SenderID"].Value = SenderID;
            }
        }

        partial void ReportPreviewScreen_Activated()
        {
            // Assign the name of the report, which you want to preview in this screen.
            if(this.ReportName == NormalPrint)
            {
                switch(Clients.ClientInfo.CurrentClient)
                {
                    case Clients.ClientInfo.Clients.FIS:
                        this.ReportTypeName = "LightSwitchApplication.PrintTemplates.FIS.FisPrint";
                        break;
                    case Clients.ClientInfo.Clients.ICC:
                        this.ReportTypeName = "LightSwitchApplication.VoucherReportKodo";
                        break;
                    case Clients.ClientInfo.Clients.INTERPOST:
                        this.ReportTypeName = "LightSwitchApplication.PrintTemplates.Interpost.InterpostPrint";
                        break;
                    case Clients.ClientInfo.Clients.Courier4U:
                        this.ReportTypeName = "LightSwitchApplication.VoucherReportCourier4U";
                        break;
                }
                //FIS
                //this.ReportTypeName = "LightSwitchApplication.VoucherReport";
                //ICC
                //this.ReportTypeName = "LightSwitchApplication.VoucherReportKodo";
                //Courier4U
                //this.ReportTypeName = "LightSwitchApplication.VoucherReportCourier4U";
                //Interpost
                //this.ReportTypeName = "LightSwitchApplication.VoucherReportInterpost";
                //this.ReportTypeName = "LightSwitchApplication.PrintTemplates.Interpost.InterpostPrint";
            }
            else
                if (this.ReportName == DriverPrint)
            {
                this.ReportTypeName = "LightSwitchApplication.Reports.EReportCustomer";
            }
                else
                    if (this.ReportName == LabelPrint)
                    {
                        this.ReportTypeName = "LightSwitchApplication.VoucherReportInterpostLabel";
                    }
            
        }

        partial void ReportPreviewScreen_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            var res = (from sender in DataWorkspace.CourierAzureData.Senders
                       where sender.Username == Application.Current.User.Name
                       select sender).FirstOrDefault();
            SenderID = res == null ? -1 : res.SenderID;
        }

    }
}