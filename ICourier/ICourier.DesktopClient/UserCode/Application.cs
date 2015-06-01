using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Threading;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.LightSwitch.Threading;
namespace LightSwitchApplication
{
    public partial class Application
    {

        partial void Application_Initialize()
        {
            //Code here
            this.Details.ClientTimeout = 60000 * 5;
                        
            /*Dictionary<string, string> queryParams = new Dictionary<string, string>();
            queryParams.Add("user","1");
            var connection = new HubConnection("http://localhost:2754/", queryParams);
            
            IHubProxy HubConnection = connection.CreateHubProxy("VoucherHub");

            // ContactHub Messages
            //HubConnection.On(Of String)("GlobalMessage", Sub(message) PixataToastHelper.ShowToast("Data Added", message, PixataToastHelper.PixataToastStyles.Alert, 10000))
            HubConnection.On<string>("GlobalMessage", new Action<string>((o) =>
            {
                var vouchersGrid = (from i in ActiveScreens where i.Screen.GetType() == typeof(EditableVouchersGrid) select i).SingleOrDefault();
                if (vouchersGrid != null)
                    ((EditableVouchersGrid)vouchersGrid.Screen).NewItemAdded();
            }));

            //' Start Connection
            connection.Start().Wait();*/
        }

        

        partial void CreateNewSender_CanRun(ref bool result)
        {
            // Set result to the desired field value
            if (this.User.HasPermission(Permissions.CanEditSenderDetails))
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        partial void EditableSendersGrid_CanRun(ref bool result)
        {
            // Set result to the desired field value
            if (this.User.HasPermission(Permissions.CanEditSendersList))
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        partial void SearchVouchersViews_CanRun(ref bool result)
        {
            // Set result to the desired field value
            if (this.User.HasPermission(Permissions.CanSearchSenderVouchers))
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        partial void EditableCostCentersGrid_CanRun(ref bool result)
        {
            // Set result to the desired field value

        }

        private Timer _timer;

        partial void Application_LoggedIn()
        {

            if (_timer == null)
            {
                _timer = new Timer(x =>
                {
                    this.Details.Dispatcher.BeginInvoke(() =>
                    {
                        var item = this.CreateDataWorkspace().CourierAzureData.Senders.FirstOrDefault();
                    });

                }, null, 15000, 30000);
            }

            var res = (from sender in this.CreateDataWorkspace().CourierAzureData.Senders
                       where sender.Username == Application.Current.User.Name
                       select sender).FirstOrDefault();

            if (res != null)
            {
                if (res.RealTimeNotification != true)
                    return;
                InitSignalREnvironment(res.SenderID.ToString());
            }
        }

        private void InitSignalREnvironment(string senderID)
        {
            try
            {
                Dictionary<string, string> queryParams = new Dictionary<string, string>();
                queryParams.Add("user", senderID);

                //var connection = new HubConnection("http://localhost:2754/", queryParams);
               // string host = null;
               // Dispatchers.Main.Invoke(() => host = System.Windows.Application.Current.Host.Source.Host);

                //var connection = new HubConnection("http://icourierfis.azurewebsites.net", queryParams);
                var connection = new HubConnection("http://testcourier.azurewebsites.net", queryParams);


                IHubProxy HubConnection = connection.CreateHubProxy("VoucherHub");

                // ContactHub Messages
                HubConnection.On<string>("GlobalMessage", new Action<string>((o) =>
                {
                    var vouchersGrid = (from i in ActiveScreens where i.Screen.GetType() == typeof(EditableVouchersGrid) select i).SingleOrDefault();
                    if (vouchersGrid != null)
                        ((EditableVouchersGrid)vouchersGrid.Screen).NewItemAdded();
                }));

                //Start Connection
                connection.Start().Wait();
            }
            catch(Exception ex)
            {

            }
        }

        partial void VoucherEditScreen_CanRun(ref bool result, decimal VoucherID)
        {
            /*var item = (from i in this.CreateDataWorkspace().CourierAzureData.Vouchers where i.VoucherID == VoucherID select i).FirstOrDefault();
            if (item != null && item.IsTaken == true)
            {
                result = false;
            }*/
        }
    }
}
