using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightSwitchApplication.Data
{
    public enum ErrorCodes
    {
        Ok = 0,
        AuthenticationFailed = 1,
        NotImplemented = 2,
        NoData = 3,
        InvalidOperation = 4,
        MaxVoucherNoReached = 5,
        MaxSubvoucherNoReached = 6,
        ValidationFailed = 7,
        SQLError = 8,
        DoesNotExist = 9,
        NotAuthorized = 10,
        InvalidKey = 11,
        RuntimeError = 12,
        JobCanceled = 13,
        ServerBusy = 14,
        RequestLimitReached = 15
    }
}