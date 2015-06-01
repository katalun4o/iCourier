using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class GetVoucherJobResult
    {
        public int Result { get; set; }
        public int JobId { get; set; }
        public VoucherJob Job { get; set; }
    }
}