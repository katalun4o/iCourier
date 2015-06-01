using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class ExcelLayout
    {
        partial void ExcelLayout_Created()
        {
            this.Sender = GetSender();
        }

        public Sender GetSender()
        {
            var res = (from sender in DataWorkspace.CourierAzureData.Senders
                       where sender.Username == Application.User.Name
                       select sender).FirstOrDefault();
            return res;
        }
    }
}
