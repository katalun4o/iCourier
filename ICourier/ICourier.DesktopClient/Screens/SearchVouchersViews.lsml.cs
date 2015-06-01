using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class SearchVouchersViews
    {
        partial void SearchVouchersViews_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            DateFrom = DateTime.Today;
            DateTo = DateTime.Today.AddDays(1);
            
        }

        partial void VouchersViews_Loaded(bool succeeded)
        {
            RecordsCount = VouchersViews.Count;
            AntikatavoliTotal = (from i in VouchersViews select i.Antikatavoli).Sum().Value;
        }

    }
}
