using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class CreateJobResult
    {
        public int Result { get; set; }
        public int JobId { get; set; }
        public string Voucher { get; set; }
        public Record[] SubVouchers { get; set; }
    }
}