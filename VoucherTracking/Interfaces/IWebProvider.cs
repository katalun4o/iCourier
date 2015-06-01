using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoucherTracking.Data;

namespace VoucherTracking.Interfaces
{
    public interface IWebProvider
    {
        string GetProvider();
        WebVoucherStatusResult GetVoucherStatus(string number);
    }
}
