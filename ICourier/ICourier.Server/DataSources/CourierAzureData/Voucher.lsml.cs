using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Voucher
    {
        partial void Voucher_Created()
        {
            this.Sender = GetSender();            
            this.Count = 1;            
            this.PayerType = 1;
            this.CashCheck = 1;

            //default for Interpost
            //this.PackageType = 2;
            //this.Weight = 0.1M;
            //this.Antikatavoli = 0;
        }

        public Sender GetSender()
        {
            var res = (from sender in DataWorkspace.CourierAzureData.Senders
                       where sender.Username == Application.User.Name
                       select sender).FirstOrDefault();
            return res;
        }

        partial void IsSaturday_Changed()
        {
            if(IsSaturday == true)
            {
                if (Memo == null || !Memo.Contains("ΠΑΡΑΔΟΣΗ ΣΑΒΒΑΤΟ"))
                {
                    Memo += " ΠΑΡΑΔΟΣΗ ΣΑΒΒΑΤΟ ";
                }
            }
            else
            {
                if (Memo != null && Memo.Contains("ΠΑΡΑΔΟΣΗ ΣΑΒΒΑΤΟ"))
                {
                    Memo = Memo.Replace("ΠΑΡΑΔΟΣΗ ΣΑΒΒΑΤΟ", "");
                }
            }
            if (Memo != null)
                Memo = Memo.Trim();
        }

        partial void IsReturn_Changed()
        {
            if (IsReturn == true)
            {
                if (Memo == null || !Memo.Contains("ΜΕ ΕΠΙΣΤΡΟΦΗ"))
                {
                    Memo += " ΜΕ ΕΠΙΣΤΡΟΦΗ ";
                }
            }
            else
            {
                if (Memo != null && Memo.Contains("ΜΕ ΕΠΙΣΤΡΟΦΗ"))
                {
                    Memo = Memo.Replace("ΜΕ ΕΠΙΣΤΡΟΦΗ", "");
                }
            }
            if (Memo != null)
                Memo = Memo.Trim();
        }


        partial void CustomDate_Compute(ref string result)
        {
            // Set result to the desired field value
            result = c_Date.Day.ToString() + "/" + c_Date.Month.ToString() + "/" + c_Date.Year.ToString();
            //result = c_Date.ToString("dd/MM/yyyy");
        }

        partial void ReceiverPK_Validate(EntityValidationResultsBuilder results)
        {
            if(string.IsNullOrEmpty(ReceiverPK))
            {
                //results.AddPropertyError("TK is required");
            }
            // results.AddPropertyError("<Error-Message>");

        }

        partial void LastStatus_Compute(ref string result)
        {
            // Set result to the desired field value
            var res = (from i in Status select i).OrderByDescending(o => o.StatusID).FirstOrDefault();
            if(res != null)
                result = res.Status1;
        }

        
    }
}
