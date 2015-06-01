using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using LightSwitchApplication.Data;

namespace LightSwitchApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public partial class Service2 //: IService2
    {
        internal static string ConnString { get; set; }
        /*public string DoWork(string p)
        {
            return "test successfull : " + p;
        }

        public string DoTestWork(string p)
        {
            return "zaek";
        }

        string IService2.TryNewMethod(string p)
        {
            return "New Method executed: " + p;
        }

        public DataVoucher AddVoucher(string webServiceCode, string date, string weight, string count, string memo, string deliveryHourFrom,
            string deliveryHourTo, string antikatavoli, string receiverCode, string receiverName,
            string receiverCity, string receiverArea, string receiverAddress, string receiverStreetNum, string receiverPhone, string receiverPK, string billOfLoading)
        {
            DataVoucher v = new DataVoucher();

            string requiredError = "{0} is required!";

            if (string.IsNullOrEmpty(date))
            {
                v.ErrorMessages.Add(string.Format(requiredError, "date"));
            }

            if (string.IsNullOrEmpty(receiverName))
            {
                v.ErrorMessages.Add(string.Format(requiredError, "receiverName"));
            }

            if (string.IsNullOrEmpty(receiverAddress))
            {
                v.ErrorMessages.Add(string.Format(requiredError, "receiverAddress"));
            }

            if (v.ErrorMessages.Count > 0)
            {
                return v;
            }

            ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["CourierAzureData"].ConnectionString;

            v.SenderID = Data.DataSender.GetSenderID(webServiceCode);

            if (v.SenderID == 0)
            {
                v.ErrorMessages.Add("Web service user code is not correct. User not found");
                return v;
            }

            DateTime dateParsed = DateTime.Today;
            if (!DateTime.TryParse(date, out dateParsed))
            {
                v.ErrorMessages.Add("Unable to parse date");
                return v;
            }
            v.Date = dateParsed;

            decimal weightParsed = 0;
            weight = weight.Replace(',', '.').Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (string.IsNullOrEmpty(weight) == false && (!decimal.TryParse(weight, out weightParsed)))
            {
                v.ErrorMessages.Add("Unable to parse weight");
                return v;
            }
            v.Weight = weightParsed;

            int countParsed = 0;
            if (string.IsNullOrEmpty(count) == false && (!int.TryParse(count, out countParsed)))
            {
                v.ErrorMessages.Add("Unable to parse count");
                return v;
            }
            v.Count = countParsed;

            v.Memo = memo ?? "";

            if (string.IsNullOrEmpty(deliveryHourFrom) == false)
            {
                DateTime deliveryHourFromParsed = DateTime.Today;
                if (string.IsNullOrEmpty(deliveryHourFrom) == false && (!DateTime.TryParse(deliveryHourFrom, out deliveryHourFromParsed)))
                {
                    v.ErrorMessages.Add("Unable to parse deliveryHourFrom");
                    return v;
                }
                v.DeliveryHourFrom = deliveryHourFromParsed;
            }

            if (string.IsNullOrEmpty(deliveryHourFrom) == false)
            {
                DateTime deliveryHourToParsed = DateTime.Today;
                if (string.IsNullOrEmpty(deliveryHourTo) == false && (!DateTime.TryParse(deliveryHourTo, out deliveryHourToParsed)))
                {
                    v.ErrorMessages.Add("Unable to parse deliveryHourTo");
                    return v;
                }
                v.DeliveryHourTo = deliveryHourToParsed;
            }

            if (string.IsNullOrEmpty(antikatavoli) == false)
            {
                decimal antikatavoliParsed = 0;
                antikatavoli = antikatavoli.Replace(',', '.').Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                if (string.IsNullOrEmpty(antikatavoli) == false && (!decimal.TryParse(antikatavoli, out antikatavoliParsed)))
                {
                    v.ErrorMessages.Add("Unable to parse antikatavoli");
                    return v;
                }
                v.Antikatalovi = antikatavoliParsed;
            }

            if (string.IsNullOrEmpty(receiverArea) == true)
            {
                receiverArea = receiverCity;
            }

            if (string.IsNullOrEmpty(receiverCity) == true)
            {
                receiverCity = receiverArea;
            }

            v.ReceiverCode = receiverCode ?? "";
            v.ReceiverName = receiverName ?? "";
            v.ReceiverCity = receiverCity ?? "";
            v.ReceiverArea = receiverArea ?? "";
            v.ReceiverAddress = receiverAddress ?? "";
            v.ReceiverStreetNum = receiverStreetNum ?? "";
            v.ReceiverPhone = receiverPhone ?? "";
            v.ReceiverPK = receiverPK ?? "";
            v.BillOfLading = billOfLoading ?? "";
            v.Save();
            //VoucherHelper.UpdateVoucherNumber(v.Voucher,res);
            //dws.CourierAzureData.SaveChanges();

            return v;
        }



*/


        
    }
}
