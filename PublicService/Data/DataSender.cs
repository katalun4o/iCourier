using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class DataSender
    {
        public static decimal GetSenderID(string webServiceCode)
        {
            decimal senderID = 0;

            using (SqlConnection cn = new SqlConnection(Service2.ConnString))
            {
                cn.OpenWithRetry();

                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    SqlCommand cm = cn.CreateCommand();
                    cm.Transaction = tr;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandText = @" SELECT TOP 1 SenderID FROM Sender WHERE WebServiceCode = @WebServiceCode";
                    cm.Parameters.AddWithValue("@WebServiceCode", webServiceCode);

                    var res = cm.ExecuteScalarWithRetry<object>();
                    senderID = Convert.ToDecimal(res);
                    //senderID = cm.ExecuteScalarWithRetry<decimal>();

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                }
            }

            return senderID;
        }

        public static decimal GetNextNumber(SqlTransaction tr, decimal senderID)
        {
            SqlCommand cm = tr.Connection.CreateCommand();
            cm.Transaction = tr;
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = @" SELECT LastVoucherNumber FROM Sender WHERE SenderID = @SenderID";
            cm.Parameters.AddWithValue("@SenderID", senderID);

            var lastNumber = cm.ExecuteScalarWithRetry<decimal>();
            lastNumber = lastNumber + 1;
            cm.CommandText = @" UPDATE Sender SET LastVoucherNumber = @LastVoucherNumber WHERE SenderID = @SenderID";
            cm.Parameters.AddWithValue("@LastVoucherNumber", lastNumber);

            cm.ExecuteNonQueryWithRetry();

            return lastNumber;
        }

        public static decimal GetNextNumber(decimal senderID)
        {
            decimal lastNumber = 0;
            using (SqlConnection cn = new SqlConnection(Service2.ConnString))
            {
                cn.OpenWithRetry();

                SqlTransaction tr = cn.BeginTransaction();
                try
                {
                    SqlCommand cm = tr.Connection.CreateCommand();
                    cm.Transaction = tr;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandText = @" UPDATE Sender SET LastVoucherNumber = LastVoucherNumber + 1 WHERE SenderID = @SenderID;
                                        SELECT LastVoucherNumber FROM Sender WHERE SenderID = @SenderID; ";
                    cm.Parameters.AddWithValue("@SenderID", senderID);

                    lastNumber = cm.ExecuteScalarWithRetry<decimal>();
                    //lastNumber = lastNumber + 1;

                    //cm.CommandText = @" UPDATE Sender SET LastVoucherNumber = @LastVoucherNumber WHERE SenderID = @SenderID";
                    //cm.Parameters.AddWithValue("@LastVoucherNumber", lastNumber);

                    //cm.ExecuteNonQueryWithRetry();

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw (ex);
                }
            }

            return lastNumber;
        }
    }
}