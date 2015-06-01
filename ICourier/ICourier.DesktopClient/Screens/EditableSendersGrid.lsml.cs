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
    public partial class EditableSendersGrid
    {
        bool firstActivated = true;
        partial void EditableSendersGrid_Activated()
        {
            // Write your code here.
            if (firstActivated == true)
            {
                firstActivated = false;
            }
            else
            {
                Senders.Refresh();
            }
        }

        partial void EditableSendersGrid_Saving(ref bool handled)
        {
            // Write your code here.
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
