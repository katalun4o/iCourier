using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Web;

namespace LightSwitchApplication.PrintTemplates.Delatolas
{
    public class Cloner
    {
        public static VouchersView Clone(VouchersView voucher)
        {
            // Get all the fields of the type, also the privates.
            PropertyInfo[] pis = voucher.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            // Create a new person object
            VouchersView newVouchersView = new VouchersView();
            // Loop through all the fields and copy the information from the parameter class
            // to the newPerson class.
            foreach (PropertyInfo pi in pis)
            {
                if (pi.SetMethod == null)
                    continue;

                pi.SetValue(newVouchersView, pi.GetValue(voucher));
            }
            // Return the cloned object.
            return newVouchersView;

        }
    }
}