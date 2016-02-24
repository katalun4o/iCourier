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
            fieldNames.Add("Number", new GridColumnInfo("ΑΡΙΘΜΟΣ", true, 1));
            fieldNames.Add("Volume", new GridColumnInfo("Κυβικά", true, 2));
            fieldNames.Add("PayWayCash", new GridColumnInfo("Τρόπος Αντικαταβολής - Μετρητά", true, 3));
            fieldNames.Add("PayWayCheck", new GridColumnInfo("Τρόπος Αντικαταβολής - Επιταγή", true, 4));
            fieldNames.Add("PayWayBillOfExchange", new GridColumnInfo("Τρόπος Αντικαταβολής - Συναλαγματική", true, 5));
            fieldNames.Add("PayWayDesc", new GridColumnInfo("Σχόλια Αντικαταβολής", true, 6));
            fieldNames.Add("DeliveryNoteInvoice", new GridColumnInfo("Δελτίο Αποστολής - Τιμολόγιο", true, 7));
            fieldNames.Add("VoucherGroup", new GridColumnInfo("Ομάδα", true, 8));
            fieldNames.Add("PackType", new GridColumnInfo("Είδος συσκευασίας", true, 9));
            fieldNames.Add("Invoice", new GridColumnInfo("Παραστατικό", true, 10));
            fieldNames.Add("MobilePhone", new GridColumnInfo("Κινητό τηλέφωνο", true, 11));
            fieldNames.Add("PayWay", new GridColumnInfo("Payment Way", true, 12));
            fieldNames.Add("CurrentCustomer", new GridColumnInfo("ΑΝΑΖ.ΠΕΛΑΤΕΣ", true, 13));
            fieldNames.Add("SenderTaxNum", new GridColumnInfo("AΦΜ", true, 13));
            fieldNames.Add("ReceiverCode", new GridColumnInfo("ΚΩΔΙΚΟΣ", true, 14));
            fieldNames.Add("ReceiverName", new GridColumnInfo("ΠΑΡΑΛΗΠΤΗΣ", true, 15));
            fieldNames.Add("ReceiverAddress", new GridColumnInfo("Δ/ΝΣΗ", true, 16));
            fieldNames.Add("ReceiverStreetNum", new GridColumnInfo("ΑΡ.", true, 17));
            fieldNames.Add("ReceiverCity", new GridColumnInfo("ΝΟΜΟΣ", true, 18));
            fieldNames.Add("ReceiverArea", new GridColumnInfo("ΠΕΡΙΟΧΗ", true, 19));
            fieldNames.Add("ReceiverPK", new GridColumnInfo("TK", true, 20));
            fieldNames.Add("ReceiverPhone", new GridColumnInfo("ΤΗΛ.", true, 21));
            fieldNames.Add("ReceiverPhone1", new GridColumnInfo("ΤΗΛ.1", false, 22));
            fieldNames.Add("Antikatavoli", new GridColumnInfo("ΑΝΤ/ΛΗ", true, 23));
            fieldNames.Add("CashCheck", new GridColumnInfo("ΤΡ. ΠΛ.", false, 24));
            fieldNames.Add("Memo", new GridColumnInfo("ΣΧΟΛΙΑ", true, 25));
            fieldNames.Add("DeliveryHourFrom", new GridColumnInfo("ΩΡΑ ΑΠΟ", true, 26));
            fieldNames.Add("DeliveryHourTo", new GridColumnInfo("ΩΡΑ ΕΩΣ", true, 27));
            fieldNames.Add("PayerType", new GridColumnInfo("ΧΡΕΩΣΗ", true, 28));
            fieldNames.Add("PackageType", new GridColumnInfo("ΔΕΜΑ/ΦΑΚΕΛΟΣ", false, 29));
            fieldNames.Add("IsReturn", new GridColumnInfo("ΕΠΙΣΤΡΟΦΗ", true, 30));
            fieldNames.Add("IsSaturday", new GridColumnInfo("ΣΑΒΒΑΤΟ", true, 31));
            fieldNames.Add("CostCenter", new GridColumnInfo("ΚΕΝΤΡΟ ΚΟΣΤΟΥΣ", true, 32));
            fieldNames.Add("Weight", new GridColumnInfo("ΒΑΡΟΣ", true, 33));
            fieldNames.Add("Count", new GridColumnInfo("ΤΕΜΑΧΙΑ", true, 34));
            fieldNames.Add("c_Date", new GridColumnInfo("ΗΜ/ΝΙΑ", true, 35));
            fieldNames.Add("IsPrinted", new GridColumnInfo("ΕΚΤΥΠΩΣΗΣ", true, 36));
            fieldNames.Add("BillOfLading", new GridColumnInfo("Φορτωτική", true, 37));
            fieldNames.Add("Memo1", new GridColumnInfo("Σχόλια 1", true, 38));
            fieldNames.Add("Memo2", new GridColumnInfo("Σχόλια 2", true, 39));
            fieldNames.Add("TimeCommitment", new GridColumnInfo("Δεσμεύση ώρας", true, 40));

            foreach (var c in columns)
            {
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
