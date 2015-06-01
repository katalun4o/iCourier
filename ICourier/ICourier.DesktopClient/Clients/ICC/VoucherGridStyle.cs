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

namespace LightSwitchApplication.Clients.ICC
{
    public class VoucherGridStyle
    {
        public static void CreateStyle(ObservableCollection<DataGridColumn> columns)
        {
            System.Collections.Generic.Dictionary<string, GridColumnInfo> fieldNames = new System.Collections.Generic.Dictionary<string, GridColumnInfo>();
            fieldNames.Add("Number", new GridColumnInfo("ΑΡΙΘΜΟΣ", true, 1));
            fieldNames.Add("CurrentCustomer", new GridColumnInfo("ΑΝΑΖ.ΠΕΛΑΤΕΣ", true, 2));
            fieldNames.Add("ReceiverCode", new GridColumnInfo("ΚΩΔΙΚΟΣ", true, 3));
            fieldNames.Add("ReceiverName", new GridColumnInfo("ΠΑΡΑΛΗΠΤΗΣ", true, 4));
            fieldNames.Add("ReceiverAddress", new GridColumnInfo("Δ/ΝΣΗ", true, 5));
            fieldNames.Add("ReceiverStreetNum", new GridColumnInfo("ΑΡ.", true, 6));
            fieldNames.Add("ReceiverCity", new GridColumnInfo("ΝΟΜΟΣ", true, 7));
            fieldNames.Add("ReceiverArea", new GridColumnInfo("ΠΕΡΙΟΧΗ", true, 8));
            fieldNames.Add("ReceiverPK", new GridColumnInfo("TK", true, 9));
            fieldNames.Add("ReceiverPhone", new GridColumnInfo("ΤΗΛ.", true, 10));
            fieldNames.Add("ReceiverPhone1", new GridColumnInfo("ΤΗΛ.1", false, 11));
            fieldNames.Add("Antikatavoli", new GridColumnInfo("ΑΝΤ/ΛΗ", true, 12));
            fieldNames.Add("CashCheck", new GridColumnInfo("ΤΡ. ΠΛ.", false, 13));
            fieldNames.Add("Memo", new GridColumnInfo("ΣΧΟΛΙΑ", true, 14));
            fieldNames.Add("DeliveryHourFrom", new GridColumnInfo("ΩΡΑ ΑΠΟ", true, 15));
            fieldNames.Add("DeliveryHourTo", new GridColumnInfo("ΩΡΑ ΕΩΣ", true, 16));
            fieldNames.Add("PayerType", new GridColumnInfo("ΧΡΕΩΣΗ", true, 17));
            fieldNames.Add("PackageType", new GridColumnInfo("ΔΕΜΑ/ΦΑΚΕΛΟΣ", false, 18));
            fieldNames.Add("IsReturn", new GridColumnInfo("ΕΠΙΣΤΡΟΦΗ", true, 19));
            fieldNames.Add("IsSaturday", new GridColumnInfo("ΣΑΒΒΑΤΟ", true, 20));
            fieldNames.Add("CostCenter", new GridColumnInfo("ΚΕΝΤΡΟ ΚΟΣΤΟΥΣ", true, 21));
            fieldNames.Add("Weight", new GridColumnInfo("ΒΑΡΟΣ", true, 22));
            fieldNames.Add("Count", new GridColumnInfo("ΤΕΜΑΧΙΑ", true, 23));
            fieldNames.Add("c_Date", new GridColumnInfo("ΗΜ/ΝΙΑ", true, 24));
            fieldNames.Add("IsPrinted", new GridColumnInfo("ΕΚΤΥΠΩΣΗΣ", true, 25));
            fieldNames.Add("BillOfLading", new GridColumnInfo("Φορτωτική", true, 26));
            fieldNames.Add("Memo1", new GridColumnInfo("Σχόλια 1", true, 27));
            fieldNames.Add("Memo2", new GridColumnInfo("Σχόλια 2", true, 28));
            fieldNames.Add("TimeCommitment", new GridColumnInfo("Δεσμεύση ώρας", true, 29));



            foreach (var c in columns)
            {
                ContentItemWrapperForColumnHeader headerFeature = (ContentItemWrapperForColumnHeader)c.Header;
                if (headerFeature != null)
                {
                    if (fieldNames.ContainsKey(c.SortMemberPath))
                    {
                        headerFeature.ContentItem.DisplayName = fieldNames[c.SortMemberPath].Caption;
                        if (fieldNames[c.SortMemberPath].Visible)
                        {
                            c.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            c.Visibility = Visibility.Collapsed;
                        }
                    }
                }
            }
        }
    }
}
