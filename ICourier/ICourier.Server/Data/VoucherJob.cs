using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public class VoucherJob
    {
        public int Id { get; set; }
        public JobType Type { get; set; }
        
        public Record Voucher{get;set;}

        public Record ReturningVoucher { get; set; }

        public Record[] SubVouchers { get; set; }

        public DateTime Date { get; set; }

        public string OrderId { get; set; }

        public bool IsClosed{ get; set; }
        public bool IsCanceled{ get; set; }
        public string Status{ get; set; }
        public DateTime StatusDate { get; set; }
        public string User{ get; set; }
        
    }

    public enum JobType
    {
        Voucher,//A normal shipment
        Pickup,//An order to go to a client and pickup a package to be returned to you
        SendAndReturn//Sent some papers to a client and get back from him some other papers
    }
}