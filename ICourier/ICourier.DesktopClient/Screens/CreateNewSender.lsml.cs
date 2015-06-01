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
    public partial class CreateNewSender
    {
        partial void CreateNewSender_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.SenderProperty = DataWorkspace.CourierAzureData.Senders_SingleOrDefault(GetCurrentSenderID());
            //this.SenderProperty = new Sender();
        }

        private decimal GetCurrentSenderID()
        {
            var res = (from sender in DataWorkspace.CourierAzureData.Senders
                       where sender.Username == Application.Current.User.Name
                       select sender).FirstOrDefault();
            decimal senderID = res == null ? -1 : res.SenderID;
            return senderID;
        }

        partial void CreateNewSender_Saved()
        {
            // Write your code here.
            this.Close(false);
            //Application.Current.ShowDefaultScreen(this.SenderProperty);
        }

        partial void CreateNewSender_Saving(ref bool handled)
        {
            handled = true;
            try
            {
                this.DataWorkspace.CourierAzureData.SaveChanges();
            }
            catch (ConcurrencyException ex)
            {
                foreach (IEntityObject conflict in ex.EntitiesWithConflicts)
                {
                    conflict.Details.EntityConflict.ResolveConflicts
                         (Microsoft.LightSwitch.Details.ConflictResolution.ServerWins);
                }
                this.DataWorkspace.CourierAzureData.SaveChanges();
            }

        }
    }
}