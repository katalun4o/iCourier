using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.LightSwitch;

namespace LightSwitchApplication
{
    public class VoucherHelper
    {
        static bool kodolabadosAlg = false;
        public static void GenerateVoucherNumbers(string voucherIDs, bool raiseIsTakenFlag = false, bool isNormalPrint = true)
        {
            DataWorkspace dws = Application.Current.CreateDataWorkspace();
            Sender res = (from sender in dws.CourierAzureData.Senders
                       where sender.Username == Application.Current.User.Name
                       select sender).FirstOrDefault();

            string[] voucherIDsArray = voucherIDs.Split(',');
            foreach(string vID in voucherIDsArray)
            {
                decimal vIDDecimal = decimal.Parse(vID);
                var voucher = (from v in dws.CourierAzureData.Vouchers
                                where v.VoucherID == vIDDecimal
                                select v).FirstOrDefault();

                if (voucher != null)
                {
                    if (isNormalPrint)
                        voucher.IsPrinted = true;

                    if (string.IsNullOrEmpty(voucher.Number))
                        UpdateVoucherNumber(voucher, res);

                    if (raiseIsTakenFlag)
                        voucher.IsTaken = true;
                }
            }
            

            dws.CourierAzureData.SaveChanges();
            //UpdateVoucherNumber(,res);
        }

        internal static void UpdateVoucherNumber(Voucher voucher, Sender s)
        {
            if (s.LastVoucherNumber == null || s.LastVoucherNumber < s.VoucherNumberFrom)
                s.LastVoucherNumber = s.VoucherNumberFrom;

            if (kodolabadosAlg == true)
            {
                string newNumber = GenerateNumber(s.LastVoucherNumber.ToString(), false);
                //decimal decNewNumber = decimal.Parse(newNumber);
                //if (s.VoucherNumberTo < decNewNumber)
                //{
                    //error
                //}
                voucher.Number = newNumber;
                s.LastVoucherNumber = decimal.Parse(voucher.Number);
            }
            else
            {
                voucher.Number = (s.LastVoucherNumber + 1).ToString();
                s.LastVoucherNumber++;
            }


            voucher.IsPrinted = true;
        }


        public static string GenerateNumber(string startNumber, bool firstTime)
        {
            if (startNumber.Length > 12)
                return "";

            long startNum = 0;
            if (long.TryParse(startNumber, out startNum) == false)
                return "";

            if (startNumber.Length == 8 || startNumber.Length == 10 || startNumber.Length == 12)
                startNumber = startNumber.Remove(startNumber.Length - 1);
            long a = 0;
            if (long.TryParse(startNumber, out a) == false)
                return "";
            if (firstTime == false)
                a++;
            long r = a % 7;
            string returnString = (startNumber.Length == 7 ? a.ToString("0000000") : a.ToString("000000000")) + r.ToString();

            long res = long.Parse(returnString);

            if (res < startNum)
            {
                return GenerateNumber((startNum + 1).ToString(), true);
            }

            return returnString;
        }
    }
}