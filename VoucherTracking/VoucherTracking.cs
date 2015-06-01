using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoucherTracking.Data;

namespace VoucherTracking
{
    public class VoucherTracking
    {
        public enum ProviderTypes
        {
            Elta,
            UPS
        }

        public Interfaces.IWebProvider GetProvider(ProviderTypes provider)
        {
            Interfaces.IWebProvider prov = null;
            switch (provider)
            {
                case ProviderTypes.Elta:
                    prov = new Providers.Elta();
                    break;
                case ProviderTypes.UPS:
                    prov = new Providers.UPS();
                    break;
            }

            return prov;
        }

        public WebVoucherStatusResult GetVoucherStatus(string number, ProviderTypes provider)
        {
            return GetProvider(provider).GetVoucherStatus(number);
        }
    }
}
