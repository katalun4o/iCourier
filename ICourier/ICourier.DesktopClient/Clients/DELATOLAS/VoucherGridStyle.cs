using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.LightSwitch.Presentation.Implementation.Controls;

namespace LightSwitchApplication.Clients.DELATOLAS
{
    public class VoucherGridStyle
    {
        public static void CreateStyle(ObservableCollection<DataGridColumn> columns)
        {
            System.Collections.Generic.Dictionary<string, GridColumnInfo> fieldNames = new System.Collections.Generic.Dictionary<string, GridColumnInfo>();
            fieldNames.Add("Number", new GridColumnInfo("ΑΡΙΘΜΟΣ", true, fieldNames.Count + 1));
            fieldNames.Add("Volume", new GridColumnInfo("Κυβικά", true, fieldNames.Count + 1));
            fieldNames.Add("PayWayCash", new GridColumnInfo("Τρόπος Αντικαταβολής - Μετρητά", true, fieldNames.Count + 1));
            fieldNames.Add("PayWayCheck", new GridColumnInfo("Τρόπος Αντικαταβολής - Επιταγή", true, fieldNames.Count + 1));
            fieldNames.Add("PayWayBillOfExchange", new GridColumnInfo("Τρόπος Αντικαταβολής - Συναλαγματική", true, fieldNames.Count + 1));
            fieldNames.Add("PayWayDesc", new GridColumnInfo("Σχόλια Αντικαταβολής", true, fieldNames.Count + 1));
            fieldNames.Add("DeliveryNoteInvoice", new GridColumnInfo("Δελτίο Αποστολής - Τιμολόγιο", true, fieldNames.Count + 1));
            fieldNames.Add("VoucherGroup", new GridColumnInfo("Ομάδα", true, fieldNames.Count + 1));
            fieldNames.Add("PackType", new GridColumnInfo("Είδος συσκευασίας", true, fieldNames.Count + 1));
            fieldNames.Add("Invoice", new GridColumnInfo("Παραστατικό", true, fieldNames.Count + 1));
            fieldNames.Add("MobilePhone", new GridColumnInfo("Κινητό τηλέφωνο", true, fieldNames.Count + 1));
            fieldNames.Add("PayWay", new GridColumnInfo("Payment Way", true, fieldNames.Count + 1));
            fieldNames.Add("CurrentCustomer", new GridColumnInfo("ΑΝΑΖ.ΠΕΛΑΤΕΣ", true, fieldNames.Count + 1));            
            fieldNames.Add("ReceiverCode", new GridColumnInfo("ΚΩΔΙΚΟΣ", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverName", new GridColumnInfo("ΠΑΡΑΛΗΠΤΗΣ", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverAddress", new GridColumnInfo("Δ/ΝΣΗ", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverStreetNum", new GridColumnInfo("ΑΡ.", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverCity", new GridColumnInfo("ΝΟΜΟΣ", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverArea", new GridColumnInfo("ΠΕΡΙΟΧΗ", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverPK", new GridColumnInfo("TK", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverTaxNum", new GridColumnInfo("AΦΜ", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverPhone", new GridColumnInfo("ΤΗΛ.", true, fieldNames.Count + 1));
            fieldNames.Add("ReceiverPhone1", new GridColumnInfo("ΤΗΛ.1", false, fieldNames.Count + 1));
            fieldNames.Add("Antikatavoli", new GridColumnInfo("ΑΝΤ/ΛΗ", true, fieldNames.Count + 1));
            fieldNames.Add("CashCheck", new GridColumnInfo("ΤΡ. ΠΛ.", false, fieldNames.Count + 1));
            fieldNames.Add("Memo", new GridColumnInfo("ΣΧΟΛΙΑ", true, fieldNames.Count + 1));
            fieldNames.Add("DeliveryHourFrom", new GridColumnInfo("ΩΡΑ ΑΠΟ", true, fieldNames.Count + 1));
            fieldNames.Add("DeliveryHourTo", new GridColumnInfo("ΩΡΑ ΕΩΣ", true, fieldNames.Count + 1));
            fieldNames.Add("PayerType", new GridColumnInfo("ΧΡΕΩΣΗ", true, fieldNames.Count + 1));
            fieldNames.Add("PackageType", new GridColumnInfo("ΔΕΜΑ/ΦΑΚΕΛΟΣ", false, fieldNames.Count + 1));
            fieldNames.Add("IsReturn", new GridColumnInfo("ΕΠΙΣΤΡΟΦΗ", true, fieldNames.Count + 1));
            fieldNames.Add("IsSaturday", new GridColumnInfo("ΣΑΒΒΑΤΟ", true, fieldNames.Count + 1));
            fieldNames.Add("CostCenter", new GridColumnInfo("ΚΕΝΤΡΟ ΚΟΣΤΟΥΣ", true, fieldNames.Count + 1));
            fieldNames.Add("Weight", new GridColumnInfo("ΒΑΡΟΣ", true, fieldNames.Count + 1));
            fieldNames.Add("Count", new GridColumnInfo("ΤΕΜΑΧΙΑ", true, fieldNames.Count + 1));
            fieldNames.Add("c_Date", new GridColumnInfo("ΗΜ/ΝΙΑ", true, fieldNames.Count + 1));
            fieldNames.Add("IsPrinted", new GridColumnInfo("ΕΚΤΥΠΩΣΗΣ", true, fieldNames.Count + 1));
            fieldNames.Add("BillOfLading", new GridColumnInfo("Φορτωτική", true, fieldNames.Count + 1));
            fieldNames.Add("Memo1", new GridColumnInfo("Σχόλια 1", true, fieldNames.Count + 1));
            fieldNames.Add("Memo2", new GridColumnInfo("Σχόλια 2", true, fieldNames.Count + 1));
            fieldNames.Add("TimeCommitment", new GridColumnInfo("Δεσμεύση ώρας", true, fieldNames.Count + 1));

            int columnCounter = 0;
            foreach (var c in columns)                
            {
                c.Visibility = Visibility.Collapsed;
                columnCounter++;
                                
                ContentItemWrapperForColumnHeader headerFeature = (ContentItemWrapperForColumnHeader)c.Header;
                if (headerFeature != null)
                {
                    if (c.SortMemberPath != null && fieldNames.ContainsKey(c.SortMemberPath))
                    {
                        GridColumnInfo colInfo = fieldNames[c.SortMemberPath];
                        headerFeature.ContentItem.DisplayName = colInfo.Caption;
                        if (colInfo.Visible)
                        {
                            c.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            c.Visibility = Visibility.Collapsed;
                        }
                        c.DisplayIndex = colInfo.DisplayIndex;
                    }
                }
            }
        }
    }
}
