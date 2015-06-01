using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using VoucherTracking.Data;

namespace VoucherTracking.Providers
{
    public class UPS : Interfaces.IWebProvider
    {

        public string GetProvider()
        {
            return "UPS";
        }

        public WebVoucherStatusResult GetVoucherStatus(string number)
        {
            WebVoucherStatusResult statusResult = new WebVoucherStatusResult();
            WebRequest request = WebRequest.Create("http://www.elta-courier.gr/en/webservice_client.php?br=" + number);
            var response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(dataStream))
            {
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                if (responseFromServer.Contains("The is no data for this shipping number"))
                {
                    statusResult.HasErrors = true;
                    statusResult.ErrorMessage = "Voucher not found";
                    return statusResult;
                }

                string htmlToParse = responseFromServer;
                int startResInd = htmlToParse.IndexOf(@"<div id=""track-results"">");
                int endResInd = htmlToParse.IndexOf(@"</div>");
                string html = htmlToParse.Substring(startResInd + @"<div id=""track-results"">".Length, endResInd - startResInd - @"<div id=""track-results"">".Length);

                statusResult.VoucherStatuses = GetEltaVoucherResults(html);
            }
            return statusResult;
        }

        private List<WebVoucherStatus> GetEltaVoucherResults(string html)
        {
            List<WebVoucherStatus> eltaResult = new List<WebVoucherStatus>();

            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("<tr>(.*?)</tr>");
            System.Text.RegularExpressions.MatchCollection results = regEx.Matches(html);
            if (results != null && results.Count > 0)
            {
                foreach (System.Text.RegularExpressions.Match result in results)
                {
                    string match = result.Value;
                    if (result.Groups.Count > 1)
                    {
                        //gets inner text
                        string row = result.Groups[1].Value;
                        WebVoucherStatus vouch = GetRowValues(row);
                        eltaResult.Add(vouch);
                    }
                }
            }

            return eltaResult;
        }

        private WebVoucherStatus GetRowValues(string row)
        {
            WebVoucherStatus voucherResult = new WebVoucherStatus();
            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("<td>(.*?)</td>");
            System.Text.RegularExpressions.MatchCollection results = regEx.Matches(row);
            if (results != null && results.Count > 0)
            {
                int index = 0;
                foreach (System.Text.RegularExpressions.Match result in results)
                {
                    string match = result.Value;
                    if (result.Groups.Count > 1)
                    {
                        //gets inner text
                        string s = result.Groups[1].Value;
                        switch (index)
                        {
                            case 0:
                                voucherResult.Status = s;
                                break;
                            case 1:
                                voucherResult.Date = s;
                                break;
                            case 2:
                                voucherResult.Time = s;
                                break;
                            case 3:
                                voucherResult.Area = s;
                                break;
                        }
                    }
                    index++;
                }
            }

            return voucherResult;
        }
    }
}
