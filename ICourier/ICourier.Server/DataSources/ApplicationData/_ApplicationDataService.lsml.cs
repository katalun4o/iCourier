using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Table1Items_Inserting(Table1Item entity)
        {
            VoucherHelper.GenerateVoucherNumbers(entity.VoucherNumbers, entity.IsDriverPrint, entity.IsNormalPrint);
        }

        partial void Query_Executing(QueryExecutingDescriptor queryDescriptor)
        {
           
        }

        partial void SaveChanges_Executing()
        {
            
        }

    }
}
