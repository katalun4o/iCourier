using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Windows.Controls;
namespace LightSwitchApplication
{
    public partial class SearchVouchersViews
    {
        private const string _CONTROL = "grid";

        partial void SearchVouchersViews_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            DateFrom = DateTime.Today;
            DateTo = DateTime.Today.AddDays(1);

            this.FindControl(_CONTROL).ControlAvailable += grid_ControlAvailable;
            
        }

        private void grid_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            DataGrid _dataGrid = (DataGrid)e.Control;

            if (Clients.ClientInfo.CurrentClient == Clients.ClientInfo.Clients.DELATOLAS)
            {                
                Clients.DELATOLAS.VoucherGridStyle.CreateStyle(_dataGrid.Columns);
            }
            else
            {
                var lstNewColumns = new List<string>(new string[] { "Volume", "PayWayCash", "PayWayCheck", "PayWayBillOfExchange",
                "PayWayDesc", "DeliveryNoteInvoice", "VoucherGroup", "PackType", "Invoice", "MobilePhone", "PayWay", "CostCenterID"});
                var columns = _dataGrid.Columns.Where(c => lstNewColumns.Contains(c.SortMemberPath));
                foreach(var col in columns)
                {
                    col.Visibility = System.Windows.Visibility.Collapsed;
                }
                
            }
        }

        partial void VouchersViews_Loaded(bool succeeded)
        {
            RecordsCount = VouchersViews.Count;
            AntikatavoliTotal = (from i in VouchersViews select i.Antikatavoli).Sum().Value;
        }

    }
}
