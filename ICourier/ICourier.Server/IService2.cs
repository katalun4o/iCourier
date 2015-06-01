using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LightSwitchApplication.Data;

namespace LightSwitchApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {

        [OperationContract]
        [WebGet(UriTemplate = "/DoWork?p={p}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string DoWork(string p);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddVoucher", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        DataVoucher AddVoucher(string webServiceCode, string date, string weight, string count, string memo, string deliveryHourFrom,
            string deliveryHourTo, string antikatavoli, string receiverCode, string receiverName,
            string receiverCity, string receiverArea, string receiverAddress, string receiverStreetNum, string receiverPhone, string receiverPK, string billOfLoading);

        [OperationContract]
        [WebGet(UriTemplate = "PrintVoucher?number={number}")]
        Stream GetPdfFile(string number);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddVoucherStatus", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string AddVoucherStatus(string webServiceCode, string voucherNumber, string status, string date, string time, string area, string receiver);

       /* [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Authenticate", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        AuthenticateResult Authenticate(string sUsrName, string sUsrPwd, string applicationKey);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/CreateJob", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        CreateJobResult CreateJob(string sAuthKey, Record oVoucher, JobType eType);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetVoucherJob", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        GetVoucherJobResult GetVoucherJob(string sAuthKey, long nJobId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ClosePendingJobs", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        int ClosePendingJobs(string sAuthKey);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ClosePendingJobsByDate", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        int ClosePendingJobsByDate(string sAuthKey, DateTime dFr, DateTime dTo);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/CancelJob", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        int CancelJob(string sAuthKey, long nJobId, bool bCancel);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetJobsFromOrderId", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        GetJobsResult GetJobsFromOrderId(string sAuthKey, string sOrderId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetJobsFromOrderId", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        TrackAndTraceResult TrackAndTrace(string authKey, string voucherNo, string language);
        */
        //void GetVouchersPdf(string authKey, string[] voucherNumbers, MediaFormat format, ExtraInfoFormat extraInfoFormat)
    }
}
