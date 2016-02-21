using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Xml.Serialization;
using System.Windows.Data;
using System.Windows.Media;
using Microsoft.LightSwitch.Presentation.Implementation.Controls;
using Microsoft.LightSwitch.Threading;
namespace LightSwitchApplication
{
    public partial class EditableVouchersGrid
    {
        bool kodolabadosAlg = false;
        private const string _CONTROL = "grid";
        DataGrid _dataGrid = null;
        private const string _dpDate = "dpVoucherDate";
        private const string _chbSelectNotPrinted = "chbSelectNotPrinted";
        ObservableCollection<Voucher> selectedVouchers;        
        System.Windows.Controls.DatePicker dpVoucherDate = null;

        static Func<object, DateTime?> FuncDateFormat = new Func<object, DateTime?>((s) =>
        {
            string dateStringVal = s.ToString();
            dateStringVal = dateStringVal.Replace('.', ',')
                .Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            double val = double.Parse(dateStringVal);
            DateTime testRes = DateTime.FromOADate(val);
            return testRes;
        });
        static Func<object, bool> FuncIsReturnFormat = new Func<object, bool>((s) =>
        {
            return s != null && s.ToString() == "1";
        });

        static EditableVouchersGrid()
        {
            dicFormatFunctions.Add("DeliveryHourFrom", FuncDateFormat);
            dicFormatFunctions.Add("DeliveryHourTo", FuncDateFormat);
            dicFormatFunctions.Add("IsReturn", FuncIsReturnFormat);
        }

        partial void Print_Execute()
        {

            //Refresh();
            
            //var item = DataWorkspace.CourierAzureData.Senders.FirstOrDefault();
            
            if (selectedVouchers.Count == 0)
            {
                //show messagebox Δεν έχουν επιλεγεί δελτία
                this.ShowMessageBox("Δεν έχουν επιλεγεί δελτία");
                return;
            }

            string param = "";

            //Sender s = GetCurrentSender();
            
            foreach (Voucher voucher in selectedVouchers)
            {
                if (voucher == null)
                    continue;
                param += voucher.VoucherID.ToString() + ",";
                //if (string.IsNullOrEmpty(voucher.Number))
                    //UpdateVoucherNumber(voucher, s);
            }
            
            //DataWorkspace.CourierAzureData.SaveChanges();
            
            param = param.TrimEnd(',');

            var t1 = DataWorkspace.ApplicationData.Table1Items.AddNew();
            t1.VoucherNumbers = param;
            t1.IsNormalPrint = true;
            DataWorkspace.ApplicationData.SaveChanges();

            //DataWorkspace.ApplicationData.Table1Items.AddNew().UpdateVoucherNumbers(param);

            Application.ShowReportPreviewScreen(param, ReportPreviewScreen.NormalPrint);
        }

        private Sender GetCurrentSender()
        {
            var res = (from sender in DataWorkspace.CourierAzureData.Senders
                       where sender.Username == Application.Current.User.Name
                       select sender).FirstOrDefault();
            
            return res;
        }

        private void UpdateVoucherNumber(Voucher voucher, Sender s)
        {
            if (s.LastVoucherNumber == null || s.LastVoucherNumber < s.VoucherNumberFrom)
                s.LastVoucherNumber = s.VoucherNumberFrom;

            if(kodolabadosAlg == true)
            {
                voucher.Number = GenerateNumber(s.LastVoucherNumber.ToString(),false);
                s.LastVoucherNumber = decimal.Parse(voucher.Number);
            }
            else
            {
                voucher.Number = (s.LastVoucherNumber + 1).ToString();
                s.LastVoucherNumber++;
            }

            
            voucher.IsPrinted = true;
        }

        
        public static string GenerateNumber(string startNumber, bool firstTime)
        {
            if (startNumber.Length > 10)
                return "";

            long startNum = 0;
            if (long.TryParse(startNumber, out startNum) == false)
                return "";

            if (startNumber.Length == 8 || startNumber.Length == 10)
                startNumber = startNumber.Remove(startNumber.Length - 1);
            long a = 0;
            if (long.TryParse(startNumber, out a) == false)
                return "";
            if (firstTime == false)
                a++;
            long r = a % 7;
            string returnString = (startNumber.Length == 7 ? a.ToString("0000000") : a.ToString("000000000")) + r.ToString();

            long res = long.Parse(returnString);

            if (res < startNum)
            {
                return GenerateNumber((startNum + 1).ToString(), true);
            }

            return returnString;
        }
        
        partial void EditableVouchersGrid_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            selectedVouchers = new ObservableCollection<Voucher>();
            
            this.FindControl(_CONTROL).AddCheckBoxColumnForMultiSelection<Voucher>(selectedVouchers);
            this.FindControl(_CONTROL).ControlAvailable += grid_ControlAvailable;
            this.FindControl(_dpDate).ControlAvailable += EditableVouchersGrid_ControlAvailable;

            this.FindControl("chbSelectAll").ControlAvailable += chbSelectAll_ControlAvailable;
            this.FindControl(_chbSelectNotPrinted).ControlAvailable += chbSelectNotPrinted_ControlAvailable;
            this.FindControl("NewItems").ControlAvailable += NewItems_ControlAvailable;
           // this.FindControl("ExcelImport").ControlAvailable += ExcelImport_ControlAvailable;
            
            
            //PrintLabels
            var btnPrintLabels =  this.FindControl("PrintLabels");
            
            if(Clients.ClientInfo.CurrentClient == Clients.ClientInfo.Clients.INTERPOST)
                btnPrintLabels.IsVisible = true;
            else
                btnPrintLabels.IsVisible = false;

            VoucherDateFrom = DateTime.Today;
            VoucherDateTo = DateTime.Today.AddDays(1);

            
        }

        TextBlock lblNewItems = null;
        void NewItems_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {

            lblNewItems = (TextBlock)e.Control;
        }

        void ExcelImport_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {

            Button btnExportExcel = (Button)e.Control;
            btnExportExcel.Click += btnExportExcel_Click;
        }

        void btnExportExcel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ExcelImport_Execute();
        }
        

        void chbSelectNotPrinted_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            System.Windows.Controls.CheckBox chb = (System.Windows.Controls.CheckBox)e.Control;
            chb.IsChecked = false;
            chb.IsThreeState = false;
            chb.Checked += chbSelectNotPrinted_Checked;
            chb.Unchecked += chbSelectNotPrinted_Unchecked;
        }

        void chbSelectNotPrinted_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            //deselect all
            selectedVouchers.Clear();
            foreach (var chb in lstCheckboxes)
            {
                Voucher v = ((Voucher)chb.Tag);
                if (v == null)
                    continue;
                if (v.IsPrinted == null || v.IsPrinted == false)
                {
                    chb.IsChecked = false;
                }
            }
        }

        void chbSelectNotPrinted_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            //select all
            foreach (var chb in lstCheckboxes)
            {
                Voucher v = ((Voucher)chb.Tag);
                if (v == null)
                    continue;
                if (v.IsPrinted == null || v.IsPrinted == false)
                {
                    chb.IsChecked = true;

                    if (!selectedVouchers.Contains(v))
                        selectedVouchers.Add(v);
                }
                
            }
            foreach(var v in Vouchers)
            {
                if (v.IsPrinted == null || v.IsPrinted == false)
                {
                    if (!selectedVouchers.Contains(v))
                        selectedVouchers.Add(v);
                }
            }
        }

        List<CheckBox> lstCheckboxes = new List<CheckBox>();
        
            void grid_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            lstCheckboxes.Clear();
            _dataGrid = (DataGrid)e.Control;

                switch(Clients.ClientInfo.CurrentClient)
                {
                    case Clients.ClientInfo.Clients.FIS:
                        Clients.FIS.VoucherGridStyle.CreateStyle(_dataGrid.Columns);
                        break;
                    case Clients.ClientInfo.Clients.ICC:
                        Clients.ICC.VoucherGridStyle.CreateStyle(_dataGrid.Columns);
                        break;
                    case Clients.ClientInfo.Clients.INTERPOST:
                        Clients.INTERPOST.VoucherGridStyle.CreateStyle(_dataGrid.Columns);
                        break;
                    case Clients.ClientInfo.Clients.DELATOLAS:
                        Clients.DELATOLAS.VoucherGridStyle.CreateStyle(_dataGrid.Columns);
                        break;
                    default:
                        Clients.FIS.VoucherGridStyle.CreateStyle(_dataGrid.Columns);
                        break;
                }
            
            
                _dataGrid.LoadingRow += new EventHandler<DataGridRowEventArgs>((s2, e2) =>
                {
                    DataGridColumn column = _dataGrid.Columns[0];
                    DataGridColumn columnButton = _dataGrid.Columns[_dataGrid.Columns.Count - 1];
                    
                    var btnStatuses = columnButton.GetCellContent(e2.Row) as Button;
                    
                    var checkBox = column.GetCellContent(e2.Row) as CheckBox;
                                        
                    Voucher currentRowItem = e2.Row.DataContext as Voucher;
                    if (currentRowItem == null)
                        return;

                    bool rowEnabled = (currentRowItem.IsTaken ?? false) == false;

                    for(int i = 0; i < _dataGrid.Columns.Count; i++)
                    {
                        DataGridColumn c = _dataGrid.Columns[i];
                        var cControl = c.GetCellContent(e2.Row);
                        
                        if(cControl != null && i != 0)
                        {
                            ((DataGridCell)(cControl.Parent)).IsEnabled = rowEnabled;
                            //((Microsoft.LightSwitch.Presentation.Framework.ContentItemPresenter)cControl).IsEnabled = rowEnabled;
                            //cControl.IsEnabled = rowEnabled;
                        }
                        //    cControl.IsEnabled = rowEnabled;
                    }

                    //e2.Row.IsEnabled = (currentRowItem.IsTaken ?? false) == false;
                    checkBox.Tag = currentRowItem;
                    checkBox.IsChecked = selectedVouchers.Contains(currentRowItem);
                    if(!lstCheckboxes.Contains(checkBox))
                        lstCheckboxes.Add(checkBox);

                    var binding = new Binding("IsTaken")
                    {
                        Mode = BindingMode.TwoWay,
                        Converter = new MyColorStatus(),
                        ValidatesOnExceptions = true
                    };
                    e2.Row.SetBinding(DataGridRow.BackgroundProperty, binding);

                    /*LinearGradientBrush brush = new LinearGradientBrush(
                new GradientStopCollection() { new GradientStop() { Color = Colors.Blue, Offset = 0 }, new GradientStop() { Color = Colors.LightGray, Offset = 1 } }
                , 90);
                    //e2.Row.Background.SetValue(DataGridRow.BackgroundProperty, brush);
                    e2.Row.Background = brush;*/
                });
        }

        void chbSelectAll_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            System.Windows.Controls.CheckBox chb = (System.Windows.Controls.CheckBox)e.Control;
            chb.IsChecked = false;
            chb.IsThreeState = false;
            chb.Checked += chb_Checked;
            chb.Unchecked += chb_Unchecked;
        }

        void chb_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            //deselect all
            selectedVouchers.Clear();
            foreach (var chb in lstCheckboxes)
            {
                chb.IsChecked = false;
            }
        }

        void chb_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            //select all
            foreach (var chb in lstCheckboxes)
            {
                chb.IsChecked = true;
                Voucher v = ((Voucher)chb.Tag);
                if(!selectedVouchers.Contains(v))
                    selectedVouchers.Add(v);
            }

            foreach (var v in Vouchers)
            {
                if (!selectedVouchers.Contains(v))
                    selectedVouchers.Add(v);
            }
        }

        void EditableVouchersGrid_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            dpVoucherDate = (System.Windows.Controls.DatePicker)e.Control;
            dpVoucherDate.SelectedDateChanged += dpVoucherDate_SelectedDateChanged;
            dpVoucherDate.SelectedDate = DateTime.Today;
            VoucherDateFrom = dpVoucherDate.SelectedDate.Value;
            VoucherDateTo = dpVoucherDate.SelectedDate.Value.AddDays(1);
        }

        void dpVoucherDate_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //refresh grid with new date parameter
            VoucherDateFrom = dpVoucherDate.SelectedDate.Value;
            VoucherDateTo = dpVoucherDate.SelectedDate.Value.AddDays(1);
            selectedVouchers.Clear();
        }

        partial void gridAddAndEditNew_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridAddAndEditNew_Execute()
        {
            // Write your code here.
            Application.ShowVoucherEditScreen(0);
        }

        partial void gridEditSelected_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridEditSelected_Execute()
        {
            // Write your code here.
            if (Vouchers.SelectedItem != null)
                Application.ShowVoucherEditScreen(Vouchers.SelectedItem.VoucherID);
        }

        private static void FormatDelegate()
        { }

        

        static Dictionary<string, Delegate> dicFormatFunctions = new Dictionary<string, Delegate>();

        private OfficeIntegration.ColumnMapping CreateColumnMapping(MyColumnMapping sourceMap)
        {
            OfficeIntegration.ColumnMapping newMapping = null;

            if (sourceMap.TargetColumn == "DeliveryHourFrom" || sourceMap.TargetColumn == "DeliveryHourTo")
            {
                newMapping = new OfficeIntegration.ColumnMapping(sourceMap.SourceColumn, sourceMap.TargetColumn,
                    null, FuncDateFormat);
            }
            else
                if (sourceMap.TargetColumn == "IsReturn")
                {
                    newMapping = new OfficeIntegration.ColumnMapping(sourceMap.SourceColumn, sourceMap.TargetColumn,
                        null, FuncIsReturnFormat);
                }
                else
                {
                    newMapping = new OfficeIntegration.ColumnMapping(sourceMap.SourceColumn, sourceMap.TargetColumn);
                }
            return newMapping;
        }

        IEnumerable<Voucher> vouchersBeforeImport;
        partial void ExcelImport_Execute()
        {
            OfficeIntegration.Excel ex = new OfficeIntegration.Excel();
            ex.DataImported += Excel_DataImported;

            vouchersBeforeImport = this.Vouchers.ToArray();

            ExcelLayout exel =  (from i in queryExcelLayout where i.ScreenName == this.GetType().Name select i).SingleOrDefault();

            if (exel != null)
            {
                List<MyColumnMapping> mappings = DeSerializeFromString(exel.XML);
                if (mappings != null)
                    ex.ImportDialog(this.Vouchers,
                         mappings.Select<MyColumnMapping, OfficeIntegration.ColumnMapping>(i => CreateColumnMapping(i)).ToList(), dicFormatFunctions);
            }
            else
            {
                ex.ImportDialog(this.Vouchers, dicFormatFunctions);
            }
        }

        void Excel_DataImported(OfficeIntegration.DataImportedEventArgs e)
        {
            var vouchersAfterImport = this.Vouchers.AsEnumerable();
            var importedVouchers = vouchersAfterImport.Except(vouchersBeforeImport);

            foreach(var importedVoucher in importedVouchers)
            {
                if(importedVoucher.Antikatavoli > 0)
                {
                    if (importedVoucher.PayWay.StartsWith("M") || importedVoucher.PayWay.StartsWith("Μ"))
                    {
                        // payment cash (Metrita)
                        importedVoucher.PayWayCash = importedVoucher.Antikatavoli;
                    }
                    else
                        if (importedVoucher.PayWay.StartsWith("E") || importedVoucher.PayWay.StartsWith("Ε"))
                        {
                            // payment check (Epitages)
                            importedVoucher.PayWayCheck = importedVoucher.Antikatavoli;
                        }
                        else
                            if (importedVoucher.PayWay.StartsWith("S") || importedVoucher.PayWay.StartsWith("Σ"))
                            {
                                // payment bill of exchange (Silagmatiki)
                                importedVoucher.PayWayBillOfExchange = importedVoucher.Antikatavoli;
                            }
                }
            }


            string importString = "";
            List<MyColumnMapping> myMappings = new List<MyColumnMapping>();
            foreach(var cm in e.ColumnMappings)
            {
                if (cm.TableField != null)
                {
                    MyColumnMapping mcm = new MyColumnMapping(cm.OfficeColumn, cm.TableField.Name);
                    myMappings.Add(mcm);
                }
            }

            importString = SerializeToString(myMappings);

            ExcelLayout exel = (from i in queryExcelLayout where i.ScreenName == this.GetType().Name select i).FirstOrDefault();
            if (exel == null)
            {
                exel = DataWorkspace.CourierAzureData.ExcelLayouts.AddNew();
                exel.ScreenName = this.GetType().Name;
            }
                
            exel.XML = importString; 
            
            //DataWorkspace.CourierAzureData.SaveChanges();
            
        }

        public static string SerializeToString(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }

        public static List<MyColumnMapping> DeSerializeFromString(string xml)
        {
            List<MyColumnMapping> result = null;
            var reader = new StringReader(xml);
            var serializer1 = new XmlSerializer(typeof(List<MyColumnMapping>));
            result = (List<MyColumnMapping>)serializer1.Deserialize(reader);
            return result;
        }

        partial void CurrentCustomer_Changed()
        {
            if (CurrentCustomer == null)
                return;

            this.Vouchers.SelectedItem.ReceiverCode = CurrentCustomer.Code;
            this.Vouchers.SelectedItem.ReceiverName = CurrentCustomer.Name;
            this.Vouchers.SelectedItem.ReceiverAddress = CurrentCustomer.Address;
            this.Vouchers.SelectedItem.ReceiverStreetNum = CurrentCustomer.StreetNum;
            this.Vouchers.SelectedItem.ReceiverCity = CurrentCustomer.City;
            this.Vouchers.SelectedItem.ReceiverArea = CurrentCustomer.Area;
            this.Vouchers.SelectedItem.ReceiverPK = CurrentCustomer.PK;
            this.Vouchers.SelectedItem.ReceiverPhone = CurrentCustomer.Phone;

            CurrentCustomer = null;
        }

        partial void VoucherDateTo_Changed()
        {
            
        }

        partial void EditableVouchersGrid_Saving(ref bool handled)
        {
            // Write your code here.

        }

        bool firstActivated = true;
        partial void EditableVouchersGrid_Activated()
        {
            if (firstActivated == true)
            {
                firstActivated = false;                
            }
            else
            {
                selectedVouchers.Clear();
                foreach (var chb in lstCheckboxes)
                {
                    chb.IsChecked = false;
                }

                Vouchers.Refresh();

            }
            

        }

        partial void Vouchers_Loaded(bool succeeded)
        {
            RecordsCount = Vouchers.Count.ToString();
            AntikatavoliTotal = (from i in Vouchers select i.Antikatavoli).Sum().Value;
            InitNewItems();
        }

        partial void ExportExcel_Execute()
        {
            var expr = DataWorkspace.CourierAzureData.Query1().Expression;
            OfficeIntegration.Excel ex = new OfficeIntegration.Excel();
            var res = from i in DataWorkspace.CourierAzureData.Query1() select i;
            ex.Export(res);
        }

        partial void PrintDriversReport_Execute()
        {
            // Write your code here.
            if (selectedVouchers.Count == 0)
            {
                //show messagebox Δεν έχουν επιλεγεί δελτία
                this.ShowMessageBox("Δεν έχουν επιλεγεί δελτία");
                return;
            }

            string param = "";

            foreach (Voucher voucher in selectedVouchers)
            {
                if (voucher == null)
                    continue;
                param += voucher.VoucherID.ToString() + ",";
            }

            param = param.TrimEnd(',');

            var t1 = DataWorkspace.ApplicationData.Table1Items.AddNew();
            t1.VoucherNumbers = param;
            t1.IsDriverPrint = true;
            t1.IsNormalPrint = false;
            DataWorkspace.ApplicationData.SaveChanges();

            Application.ShowReportPreviewScreen(param, ReportPreviewScreen.DriverPrint);
        }

        partial void PrintLabels_Execute()
        {
            if (selectedVouchers.Count == 0)
            {
                //show messagebox Δεν έχουν επιλεγεί δελτία
                this.ShowMessageBox("Δεν έχουν επιλεγεί δελτία");
                return;
            }

            string param = "";

            foreach (Voucher voucher in selectedVouchers)
            {
                if (voucher == null)
                    continue;
                param += voucher.VoucherID.ToString() + ",";
            }

            param = param.TrimEnd(',');

            var t1 = DataWorkspace.ApplicationData.Table1Items.AddNew();
            t1.VoucherNumbers = param;
            t1.IsDriverPrint = false;
            t1.IsNormalPrint = false;
            DataWorkspace.ApplicationData.SaveChanges();

            Application.ShowReportPreviewScreen(param, ReportPreviewScreen.LabelPrint);
        }

        partial void ShowStatuses_Execute()
        {
            // Write your code here.
            //Vouchers.SelectedItem
            Application.ShowVoucherEditScreen(Vouchers.SelectedItem.VoucherID);
        }

        int newItemsCount = 0;

        private void InitNewItems()
        {
            NewItems = "";
            newItemsCount = 0;
            Dispatchers.Main.BeginInvoke(() =>
            {
                if (lblNewItems != null)
                    lblNewItems.Visibility = System.Windows.Visibility.Collapsed;
            });
        }

        public void NewItemAdded()
        {   
            Dispatchers.Main.BeginInvoke(() => {
                lblNewItems.Visibility = System.Windows.Visibility.Visible;
                newItemsCount++;
                string message = "";
                if (newItemsCount == 1)
                {
                    message = "Υπάρχη {0} νέα παραγγελία!";
                }
                else
                {
                    message = "Υπάρχουν {0} νέες παραγγελίες!";
                }
                NewItems = string.Format(message, newItemsCount);
            });
            //NewItems = string.Format("There are {0} new items!", newItemsCount);
        }

        
    }

    [Serializable]
    public class MyColumnMapping
    {
        public string SourceColumn { get; set; }
        public string TargetColumn { get; set; }

        public MyColumnMapping()
        {

        }

        public MyColumnMapping(string source, string target)
        {
            this.SourceColumn = source;
            this.TargetColumn = target;
        }
    }
}
