using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class CourierAzureDataService
    {
        partial void Vouchers_Validate(Voucher entity, EntitySetValidationResultsBuilder results)
        {
            
        }

        partial void Vouchers_Inserting(Voucher entity)
        {
            //decimal senderID = VoucherGlobalDef.GetCurrentSenderID();
            /*Setting s = DataWorkspace.CourierAzureData.Settings_SingleOrDefault(1);
            if (s.LastVoucherNumber == null || s.LastVoucherNumber < s.VoucherNumberFrom)
                s.LastVoucherNumber = s.VoucherNumberFrom;
            entity.Number = (s.LastVoucherNumber + 1).ToString();
            s.LastVoucherNumber++;*/
            if (entity.Sender.AutosaveCustomers == true)
            {
                bool isCityNull = false;
                if (string.IsNullOrEmpty(entity.ReceiverCity))
                    isCityNull = true;

                bool isAreaNull = false;
                if (string.IsNullOrEmpty(entity.ReceiverArea))
                    isAreaNull = true;

                bool isAddressNull = false;
                if (string.IsNullOrEmpty(entity.ReceiverAddress))
                    isAddressNull = true;

                bool isPhoneNull = false;
                if (string.IsNullOrEmpty(entity.ReceiverPhone))
                    isPhoneNull = true;

                var res = (from c in DataWorkspace.CourierAzureData.Customers
                           where c.Name == entity.ReceiverName && 
                           ((isCityNull == true && c.City == null) || c.City == entity.ReceiverCity) &&
                           ((isAreaNull == true && c.Area == null) || c.Area == entity.ReceiverArea) &&
                           ((isAddressNull == true && c.Address == null) || c.Address == entity.ReceiverAddress) &&
                           ((isPhoneNull == true && c.Phone == null) || c.Phone == entity.ReceiverPhone)                             
                          select c);

                bool exist = false;
                foreach(var r in res)
                {
                    exist = true;
                    break;
                }

                if (exist == false)
                {
                    Customer newCustomer = DataWorkspace.CourierAzureData.Customers.AddNew();
                    newCustomer.Code = entity.ReceiverCode;
                    newCustomer.Name = entity.ReceiverName;
                    newCustomer.City = entity.ReceiverCity;
                    newCustomer.Area = entity.ReceiverArea;
                    newCustomer.Address = entity.ReceiverAddress;
                    newCustomer.StreetNum = entity.ReceiverStreetNum;
                    newCustomer.Phone = entity.ReceiverPhone;
                    newCustomer.PK = entity.ReceiverPK;
                }
            }
        }

        partial void Vouchers_CanUpdate(ref bool result)
        {

        }

        partial void Vouchers_Updating(Voucher entity)
        {
            entity.IsEdited = true;
        }

    }
}
