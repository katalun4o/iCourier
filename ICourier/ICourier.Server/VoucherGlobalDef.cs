using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.LightSwitch.Framework;
using Microsoft.LightSwitch;


namespace LightSwitchApplication
{
    public class VoucherGlobalDef
    {
        //public static decimal SenderID = 0;
        public static Decimal GetCurrentSenderID()
        {
            //if (SenderID != 0)
                //return SenderID;

            var res = (from sender in Application.Current.CreateDataWorkspace().CourierAzureData.Senders 
                       where sender.Username == Application.Current.User.Name select sender).FirstOrDefault();
            decimal SenderID = res == null ? -1 : res.SenderID;
            return SenderID;
        }

        
    }
}