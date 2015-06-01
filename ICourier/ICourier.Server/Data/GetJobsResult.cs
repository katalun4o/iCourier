using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class GetJobsResult
    {
        public int Result { get; set; }
        public VoucherJob[] Jobs { get; set; }
    }
}