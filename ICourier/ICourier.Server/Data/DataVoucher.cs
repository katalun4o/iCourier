using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LightSwitchApplication
{
    [DataContract]
    public class DataVoucher
    {
        [DataMember]
        public List<string> ErrorMessages { get; set; }

        public DataVoucher()
        {
            ErrorMessages = new List<string>();
        }

        [DataMember]
        public decimal VoucherID { get; set; }

        [DataMember]
        public decimal SenderID { get; set; }

        public DateTime Date { get; set; }

        [DataMember]
        public string DateString
        {
            get
            {
                if (Date == null)
                    return "";
                return Date.ToString("yyyy-MM-dd HH:mm");
            }
            set
            {
                DateTime dateParsed = DateTime.Today;
                if (string.IsNullOrEmpty(value) == false && DateTime.TryParse(value, out dateParsed))
                {
                    Date = dateParsed;
                }
            }
        }

        [DataMember]
        public decimal Weight { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public decimal Count { get; set; }

        [DataMember]
        public string DeliveryHourFromString
        {
            get
            {
                if (DeliveryHourFrom == null)
                    return "";

                return DeliveryHourFrom.Value.ToString("HH:mm");
            }
            set
            {
                DateTime deliveryHourFromParsed = DateTime.Today;
                if (string.IsNullOrEmpty(value) == false && DateTime.TryParse(value, out deliveryHourFromParsed))
                {
                    DeliveryHourFrom = deliveryHourFromParsed;
                }
            }
        }
        
        public DateTime? DeliveryHourFrom { get; set; }


        [DataMember]
        public string DeliveryHourToString
        {
            get
            {
                if (DeliveryHourTo == null)
                    return "";

                return DeliveryHourTo.Value.ToString("HH:mm");
            }
            set
            {
                DateTime deliveryHourToParsed = DateTime.Today;
                if (string.IsNullOrEmpty(value) == false && DateTime.TryParse(value, out deliveryHourToParsed))
                {
                    DeliveryHourTo = deliveryHourToParsed;
                }
            }
        }

        public DateTime? DeliveryHourTo { get; set; }

        [DataMember]
        public decimal? Antikatalovi { get; set; }

        [DataMember]
        public bool IsPrinted { get; set; }

        [DataMember]
        public string Number { get; set; }


        [DataMember]
        public string ReceiverName { get; set; }

        [DataMember]
        public string ReceiverAddress { get; set; }

        [DataMember]
        public string ReceiverCity { get; set; }

        [DataMember]
        public string ReceiverArea { get; set; }

        [DataMember]
        public string ReceiverCode { get; set; }

        [DataMember]
        public string ReceiverPhone { get; set; }

        [DataMember]
        public string ReceiverPK { get; set; }

        [DataMember]
        public string ReceiverStreetNum { get; set; }

        [DataMember]
        public string BillOfLading { get; set; }

        public void Save()
        {
            using (SqlConnection cn = new SqlConnection(Service2.ConnString))
            {
                cn.OpenWithRetry();

                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    //Number = Data.DataSender.GetNextNumber(tr, SenderID).ToString();
                    Number = Data.DataSender.GetNextNumber(SenderID).ToString();

                    SqlCommand cm = cn.CreateCommand();
                    cm.Transaction = tr;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandText = @" 
INSERT INTO [dbo].[Voucher]
           ([SenderID]
           ,[Number]
           ,[Date]
           ,[Weight]
           ,[Count]
           ,[Memo]
           ,[DeliveryHourFrom]
           ,[DeliveryHourTo]
           ,[Antikatavoli]
           ,[IsPrinted]
           ,[ReceiverCode]
           ,[ReceiverName]
           ,[ReceiverCity]
           ,[ReceiverArea]
           ,[ReceiverAddress]
           ,[ReceiverStreetNum]
           ,[ReceiverPhone]
           ,[ReceiverPK]
           ,[BillOfLading])
     VALUES
           (
            @SenderID 
           , @Number 
           , @Date 
           , @Weight 
           , @Count 
           , @Memo 
           , @DeliveryHourFrom 
           , @DeliveryHourTo 
           , @Antikatavoli 
           , @IsPrinted 
           , @ReceiverCode 
           , @ReceiverName 
           , @ReceiverCity 
           , @ReceiverArea 
           , @ReceiverAddress 
           , @ReceiverStreetNum 
           , @ReceiverPhone 
           , @ReceiverPK 
           , @BillOfLading) 

            SELECT @@IDENTITY ";

                    cm.Parameters.AddWithValue("@SenderID", SenderID);
                    cm.Parameters.AddWithValue("@Number", Number);
                    cm.Parameters.AddWithValue("@Date", Date);
                    cm.Parameters.AddWithValue("@Weight", Weight);
                    cm.Parameters.AddWithValue("@Count", Count);
                    cm.Parameters.AddWithValue("@Memo", Memo);
                    cm.Parameters.AddWithValue("@DeliveryHourFrom", DeliveryHourFrom == null ? (object)DBNull.Value : (object)DeliveryHourFrom.Value);
                    cm.Parameters.AddWithValue("@DeliveryHourTo", DeliveryHourTo == null ? (object)DBNull.Value : (object)DeliveryHourTo.Value);
                    cm.Parameters.AddWithValue("@Antikatavoli", Antikatalovi == null ? (object)DBNull.Value : (object)Antikatalovi.Value);
                    cm.Parameters.AddWithValue("@IsPrinted", IsPrinted);
                    cm.Parameters.AddWithValue("@ReceiverCode", ReceiverCode);
                    cm.Parameters.AddWithValue("@ReceiverName", ReceiverName);
                    cm.Parameters.AddWithValue("@ReceiverCity", ReceiverCity);
                    cm.Parameters.AddWithValue("@ReceiverArea", ReceiverArea);
                    cm.Parameters.AddWithValue("@ReceiverAddress", ReceiverAddress);
                    cm.Parameters.AddWithValue("@ReceiverStreetNum", ReceiverStreetNum);
                    cm.Parameters.AddWithValue("@ReceiverPhone", ReceiverPhone);
                    cm.Parameters.AddWithValue("@ReceiverPK", ReceiverPK);
                    cm.Parameters.AddWithValue("@BillOfLading", BillOfLading);

                    VoucherID = cm.ExecuteScalarWithRetry<decimal>();

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                }
                cn.Close();
            }
        }
    }
}