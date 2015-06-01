using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class TrackAndTraceResult
    {
        public int Result { get; set; }
        public Checkpoint[] Checkpoints{get;set;}
        public string Status { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Consignee { get; set; }
    }
}