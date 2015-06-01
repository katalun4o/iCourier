using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Server;
using LightSwitchApplication.Data;
using System.ServiceModel.Web;
using System.IO;
using System.Threading;
using Microsoft.LightSwitch.Server;
using Microsoft.AspNet.SignalR;

namespace LightSwitchApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
    public partial class Service2 : IService2
    {
        internal static string ConnString { get; set; }
        public string DoWork(string p)
        { 
            VoucherHub.NotifyClients("1", "");
            return "test successfull 22: " + p;
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

            if(v.ErrorMessages.Count > 0)
            {
                return v;
            }

            ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["CourierAzureData"].ConnectionString;

            v.SenderID = LightSwitchApplication.Data.DataSender.GetSenderID(webServiceCode);

            if(v.SenderID == 0)
            {
                v.ErrorMessages.Add("Web service user code is not correct. User not found");
                return v;
            }

            DateTime dateParsed = DateTime.Today;
            if(!DateTime.TryParse(date,out dateParsed))
            {
                v.ErrorMessages.Add("Unable to parse date");
                return v;
            }
            v.Date = dateParsed;

            decimal weightParsed = 0;
            weight = weight.Replace(',', '.').Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if(string.IsNullOrEmpty(weight) == false && (!decimal.TryParse(weight, out weightParsed)))
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

            if(string.IsNullOrEmpty(receiverArea) == true)
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

            //raise notification
            VoucherHub.NotifyClients(v.SenderID.ToString(), "");

            //VoucherHelper.UpdateVoucherNumber(v.Voucher,res);
            //dws.CourierAzureData.SaveChanges();

            return v;
        }



        public string DoTestWork(string p)
        {
            throw new NotImplementedException();
        }

        public string TryNewMethod(string p)
        {
            throw new NotImplementedException();
        }


        public System.IO.Stream PrintVoucher(string number)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/pdf";
            
            //byte[] reportBytes = null;
            VoucherReportInterpost rep = new VoucherReportInterpost();
            
            using(System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                rep.ExportToPdf(ms);
                int length = (int)ms.Length;
                WebOperationContext.Current.OutgoingResponse.ContentLength = length;
                return ms;
                //reportBytes = ms.ToArray();
            }

            //return reportBytes;
        }

        //[WebGet(UriTemplate = "file/{id}")]
        public Stream GetPdfFile(string number)
        {
            try
            {                                

            //if (ServerApplicationContext.Current == null)
            //   ServerApplicationContext.CreateContext(ServerApplicationContextCreationOptions.SkipAuthentication);
            //ServerApplicationContext sac = ServerApplicationContext.CreateContext();

            //DataWorkspace workspace = (DataWorkspace)sac.Application.CreateDataWorkspace();
            //if (ServerApplicationContext.Current.DataWorkspace == null)
            //{
            //    ServerApplicationContext.Current.Application.CreateDataWorkspace();
            //}
            //DataWorkspace workspace = (DataWorkspace)ServerApplicationContext.Current.Application.CreateDataWorkspace();
            //var res = (from v in workspace.CourierAzureData2.Vouchers where v.Number == id select v).FirstOrDefault();
            //var res = (from v in ServerApplicationContext.Current.DataWorkspace.CourierAzureData1.VouchersViewDoubles where v.Number == number select v);
                ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["CourierAzureData"].ConnectionString;
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/pdf";
                //WebOperationContext.Current.OutgoingResponse.ContentType = "text/html";

                //VoucherReportInterpost rep = new VoucherReportInterpost();
                //List<object> ds = new List<object>();
                //foreach (var r in res)
                //{
                    //ds.Add(r);
                //}
                //rep.DataSource = ds;
                //rep.DataSource = new List<object>() { res };

                //PrintTemplates.XtraReport2 rep = new PrintTemplates.XtraReport2();
                //NewDataset.VouchersViewDoubleDataTable dt = new NewDataset.VouchersViewDoubleDataTable();
                DevExpress.XtraPrinting.Export.Pdf.PdfGraphics.EnableAzureCompatibility = false;

                VoucherReportInterpost rep = new VoucherReportInterpost();
                NewDataset ds = new NewDataset();
                NewDatasetTableAdapters.VouchersViewDoubleAdapter ad = new NewDatasetTableAdapters.VouchersViewDoubleAdapter();
                ad.Connection = new System.Data.SqlClient.SqlConnection(ConnString);
                ad.Connection.Open();
                ad.Fill(ds.VouchersViewDouble, number);
                ad.Connection.Close();

                //var rows = ds.VouchersViewDouble.Select("Number = '" + number + "'");
                rep.DataSource = ds.VouchersViewDouble;

                System.IO.MemoryStream f = new System.IO.MemoryStream();
                DevExpress.XtraPrinting.PdfExportOptions pdfExpOpts = new DevExpress.XtraPrinting.PdfExportOptions();
                rep.ExportToPdf(f);
                f.Position = 0;

                //FileStream f = new FileStream("C:\\test.pdf", FileMode.Open);
                int length = (int)f.Length;
                WebOperationContext.Current.OutgoingResponse.ContentLength = length;
                byte[] buffer = new byte[length];
                int sum = 0;
                int count;
                while ((count = f.Read(buffer, sum, length - sum)) > 0)
                {
                    sum += count;
                }
                f.Close();
                return new MemoryStream(buffer);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string AddVoucherStatus(string webServiceCode, string voucherNumber, string status, string date, string time, string area, string receiver)
        {
            ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["CourierAzureData"].ConnectionString;

            string res = "";
            try
            {
                DataVoucherStatus vStatus = new DataVoucherStatus();
                vStatus.Number = voucherNumber;
                vStatus.Status = status;
                vStatus.Date = date;
                vStatus.Time = time;
                vStatus.Area = area;
                vStatus.Receiver = receiver;
                res = vStatus.Save();
            }
            catch(Exception ex)
            {
                res = ex.Message;
            }
            

            return res;
        }

      /*  public AuthenticateResult Authenticate(string sUsrName, string sUsrPwd, string applicationKey)
        {
            throw new NotImplementedException();
        }

        public CreateJobResult CreateJob(string sAuthKey, Record oVoucher, JobType eType)
        {
            CreateJobResult res = new CreateJobResult();
            try
            {
                DataVoucher dv = this.AddVoucher("", DateTime.Now.ToShortDateString(), oVoucher.Weight.ToString(), oVoucher.Pieces.ToString(), oVoucher.Comments, "", "", oVoucher.InsAmount.ToString(), "",
                oVoucher.Name, oVoucher.City, "", oVoucher.Address, "", oVoucher.Telephone, oVoucher.Zip, "");
                
                if(dv.ErrorMessages.Count > 0)
                {
                    res.Result = (int)Data.ErrorCodes.ValidationFailed;
                }
                else
                {
                    res.JobId = (int)dv.VoucherID;
                    res.Voucher = dv.Number;
                    res.Result = (int)Data.ErrorCodes.Ok;
                }
            }
            catch (Exception ex)
            {
                res.Result = (int)Data.ErrorCodes.RuntimeError;
            }
            return res;
        }


        public GetVoucherJobResult GetVoucherJob(string sAuthKey, long nJobId)
        {
            throw new NotImplementedException();
        }

        public int ClosePendingJobs(string sAuthKey)
        {
            throw new NotImplementedException();
        }

        public int ClosePendingJobsByDate(string sAuthKey, DateTime dFr, DateTime dTo)
        {
            throw new NotImplementedException();
        }

        public int CancelJob(string sAuthKey, long nJobId, bool bCancel)
        {
            throw new NotImplementedException();
        }

        public GetJobsResult GetJobsFromOrderId(string sAuthKey, string sOrderId)
        {
            throw new NotImplementedException();
        }

        public TrackAndTraceResult TrackAndTrace(string authKey, string voucherNo, string language)
        {
            throw new NotImplementedException();
        }*/
    }
}
