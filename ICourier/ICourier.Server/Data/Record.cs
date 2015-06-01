using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class Record
    {
        public string OrderId { get; set; }
        public string Name{ get; set; }
        public string Address{ get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }
        public string Zip { get; set; }
        public decimal Weight { get; set; }
        public int Pieces{ get; set; }
        public string Comments { get; set; }
        public string Services{ get; set; }
        public string CodAmount{ get; set; }
        public decimal InsAmount { get; set; }
        public string VoucherNo{ get; set; }
        public string SubCode{ get; set; }
        public string BelongsTo { get; set; }
        public string DeliveredTo{ get; set; }
        public DateTime ReceivedDate{ get; set; }
    }
}