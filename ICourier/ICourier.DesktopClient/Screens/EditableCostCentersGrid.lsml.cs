using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Xml.Serialization;
namespace LightSwitchApplication
{
    public partial class EditableCostCentersGrid
    {
        partial void ExcelImport_Execute()
        {
            // Write your code here.
            OfficeIntegration.Excel ex = new OfficeIntegration.Excel();
            ex.DataImported += Excel_DataImported;


            //ExcelLayout exel = queryExcelLayout.SingleOrDefault();
            ExcelLayout exel = (from i in queryExcelLayout where i.ScreenName == this.GetType().Name select i).SingleOrDefault();

            if (exel != null)
            {
                List<MyColumnMapping> mappings = DeSerializeFromString(exel.XML);
                if (mappings != null)
                {
                    List<OfficeIntegration.ColumnMapping> lstMappings = new List<OfficeIntegration.ColumnMapping>();
                    lstMappings.AddRange(from i in mappings select new OfficeIntegration.ColumnMapping(i.SourceColumn, i.TargetColumn));
                    //lstMappings.Add(new OfficeIntegration.ColumnMapping("A", "Number"));
                    ex.ImportDialog(this.CostCenters, lstMappings);
                }

            }
            else
            {
                ex.ImportDialog(this.CostCenters);
            }
        }

        void Excel_DataImported(OfficeIntegration.DataImportedEventArgs e)
        {
            string importString = "";
            List<MyColumnMapping> myMappings = new List<MyColumnMapping>();
            foreach (var cm in e.ColumnMappings)
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
    }
}
