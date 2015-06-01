using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class DataVoucherStatus
    {
        public decimal StatusID { get; set; }
        public decimal VoucherID { get; set; }
        public string Number { get; set; }
        public string Status{ get; set; }
        public string Date{ get; set; }
        public string Time{ get; set; }
        public string Area{ get; set; }
        public string Receiver{ get; set; }

        public string Save()
        {
            using (SqlConnection cn = new SqlConnection(Service2.ConnString))
            {
                cn.OpenWithRetry();

                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    SqlCommand cm = cn.CreateCommand();
                    cm.Transaction = tr;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandText = @"SELECT VoucherID FROM Voucher WHERE Number = @Number";
                    cm.Parameters.AddWithValue("@Number", Number);
                    using(SqlDataReader dr = cm.ExecuteReaderWithRetry())
                    {
                        if(dr.Read())
                        {
                            VoucherID = dr.GetDecimal(0);
                        }
                        else
                        {
                            return "No voucher with such number";
                        }
                    }

                    cm.CommandText = @" 
INSERT INTO [dbo].[Status]
           (
            [VoucherID]
           ,[Number]
           ,[Status]
           ,[Date]
           ,[Time]
           ,[Area]
            ,[Receiver]
           )
     VALUES
           (
            @VoucherID
           ,@Number
           ,@Status
           ,@Date
           ,@Time
           ,@Area
           ,@Receiver) 

            SELECT @@IDENTITY ";

                    cm.Parameters.Clear();
                    cm.Parameters.AddWithValue("@VoucherID", VoucherID);
                    cm.Parameters.AddWithValue("@Number", Number);
                    cm.Parameters.AddWithValue("@Status", Status);
                    cm.Parameters.AddWithValue("@Date", Date);
                    cm.Parameters.AddWithValue("@Time", Time);
                    cm.Parameters.AddWithValue("@Area", Area);
                    cm.Parameters.AddWithValue("@Receiver", Receiver);

                    StatusID = cm.ExecuteScalarWithRetry<decimal>();

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    return ex.Message;
                }
                cn.Close();

                return "";
            }
        }
    }
}