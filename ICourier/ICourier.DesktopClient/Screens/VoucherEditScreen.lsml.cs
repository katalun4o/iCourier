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
    public partial class VoucherEditScreen
    {

        System.Windows.Controls.AutoCompleteBox cbReceiverCodes = null;

        partial void VoucherEditScreen_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            
            // Write your code here.
            if(this.VoucherID != 0)
            {
                this.VoucherProperty = Voucher;
            }
            else
            {
                this.VoucherProperty = new Voucher();
            }

        }

        
        
        partial void VoucherEditScreen_Saved()
        {
            this.VoucherProperty = new Voucher();
            // Write your code here.
            //this.Close(false);
            //Application.Current.ShowDefaultScreen(this.VoucherProperty);
        }

        partial void CurrentCustomer_Changed()
        {
            if (CurrentCustomer == null)
                return;
            VoucherProperty.ReceiverCode = CurrentCustomer.Code;
            VoucherProperty.ReceiverName = CurrentCustomer.Name;
            VoucherProperty.ReceiverAddress = CurrentCustomer.Address;
            VoucherProperty.ReceiverStreetNum = CurrentCustomer.StreetNum;
            VoucherProperty.ReceiverCity = CurrentCustomer.City;
            VoucherProperty.ReceiverArea = CurrentCustomer.Area;
            VoucherProperty.ReceiverPK = CurrentCustomer.PK;
            VoucherProperty.ReceiverPhone = CurrentCustomer.Phone;

            CurrentCustomer = null;
        }

        partial void Test_Execute()
        {
            // Write your code here.
            
        }

        partial void VoucherProperty_Validate(ScreenValidationResultsBuilder results)
        {
            if(VoucherProperty.IsTaken != null && VoucherProperty.IsTaken == true)
            {
                results.AddPropertyError("Voucher already taken and cannot be editted");
            }
            // results.AddPropertyError("<Error-Message>");

        }

        partial void VoucherEditScreen_Created()
        {
            // Write your code here.
            this.FindControl("Status").IsReadOnly = true;
            this.FindControl("Status").IsEnabled = false;

        }

        /*partial void Property1_Changed()
        {
            if (Property1 == null)
                return;
            VoucherProperty.ReceiverCode = Property1.ReceiverCode;
            VoucherProperty.ReceiverName = Property1.ReceiverName2;
            VoucherProperty.ReceiverAddress = Property1.ReceiverAddress;
            VoucherProperty.ReceiverStreetNum = Property1.ReceiverStreetNum;
            VoucherProperty.ReceiverCity = Property1.ReceiverCity;
            VoucherProperty.ReceiverArea = Property1.ReceiverArea;
            VoucherProperty.ReceiverPK = Property1.ReceiverPK;
            VoucherProperty.ReceiverPhone = Property1.ReceiverPhone;

            Property1 = null;
        }*/

        
        
       /* partial void searchReceiverCodeProperty_Changed()
        {
            if (searchReceiverCodeProperty == null)
                return;

            VoucherProperty.ReceiverCode = searchReceiverCodeProperty.ReceiverCode;
            VoucherProperty.ReceiverName = searchReceiverCodeProperty.ReceiverName;
            VoucherProperty.ReceiverAddress = searchReceiverCodeProperty.ReceiverAddress;
            VoucherProperty.ReceiverStreetNum = searchReceiverCodeProperty.ReceiverStreetNum;
            VoucherProperty.ReceiverCity = searchReceiverCodeProperty.ReceiverCity;
            VoucherProperty.ReceiverArea= searchReceiverCodeProperty.ReceiverArea;
            VoucherProperty.ReceiverPK= searchReceiverCodeProperty.ReceiverPK;
            VoucherProperty.ReceiverPhone = searchReceiverCodeProperty.ReceiverPhone;

            searchReceiverCodeProperty = null;
        }

        partial void searchReceiverNameProperty_Changed()
        {
            if (searchReceiverNameProperty == null)
                return;
            VoucherProperty.ReceiverCode = searchReceiverNameProperty.ReceiverCode;
            VoucherProperty.ReceiverName = searchReceiverNameProperty.ReceiverName1;
            VoucherProperty.ReceiverAddress = searchReceiverNameProperty.ReceiverAddress;
            VoucherProperty.ReceiverStreetNum = searchReceiverNameProperty.ReceiverStreetNum;
            VoucherProperty.ReceiverCity = searchReceiverNameProperty.ReceiverCity;
            VoucherProperty.ReceiverArea = searchReceiverNameProperty.ReceiverArea;
            VoucherProperty.ReceiverPK = searchReceiverNameProperty.ReceiverPK;
            VoucherProperty.ReceiverPhone = searchReceiverNameProperty.ReceiverPhone;

            searchReceiverNameProperty = null;
        }
        */
        /*partial void VoucherEditScreen_Saving(ref bool handled)
        {
            // Write your code here.
            if(!VoucherProperty.Details.ValidationResults.HasErrors)
            {
                Setting s = DataWorkspace.CourierAzureData.Settings_SingleOrDefault(1);
                if (s.LastVoucherNumber == null || s.LastVoucherNumber < s.VoucherNumberFrom)
                    s.LastVoucherNumber = s.VoucherNumberFrom;
                VoucherProperty.Number = (s.LastVoucherNumber + 1).ToString();
                s.LastVoucherNumber++;

                DataWorkspace.CourierAzureData.SaveChanges();
                this.VoucherProperty = new Voucher();
            }
            else
            {

            }

            handled = true;
        }*/
        
    }
}