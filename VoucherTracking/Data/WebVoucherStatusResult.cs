using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoucherTracking.Data
{
    public class WebVoucherStatusResult
    {
        public bool HasErrors { get; set; }
        public string ErrorMessage{get;set;}
        public List<WebVoucherStatus> VoucherStatuses { get; set; }
    }
}
