using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace LightSwitchApplication.Clients
{
    public class GridColumnInfo
    {
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public bool Visible{ get; set; }
        public int DisplayIndex{ get; set; }
        public double Size{ get; set; }

        public GridColumnInfo(string caption, bool visible = true, int displayIndex = 0, double size = -1)
        {
            this.Caption = caption;
            this.Visible = visible;
            this.DisplayIndex = displayIndex;
            Size = size;
        }
    }
}
