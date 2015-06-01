using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
        [WebGet(UriTemplate = "/DoTestWork?p={p}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string DoTestWork(string p);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/TryNewMethod", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string TryNewMethod(string p);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddVoucher", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Data.DataVoucher AddVoucher(string webServiceCode, string date, string weight, string count, string memo, string deliveryHourFrom,
            string deliveryHourTo, string antikatavoli, string receiverCode, string receiverName,
            string receiverCity, string receiverArea, string receiverAddress, string receiverStreetNum, string receiverPhone, string receiverPK, string billOfLoading);
    }
}
