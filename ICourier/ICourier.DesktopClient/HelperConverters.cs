using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{


    public class MyColorRating : IValueConverter
    {
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            Color color = Colors.Transparent;

            if (value != null)
            {
                Type t = value.GetType();
                string val = value.ToString();
                if (t.ToString() == "Microsoft.LightSwitch.Presentation.Implementation.InlineWrapperEntity")
                {
                    var v = value as Microsoft.LightSwitch.Presentation.Implementation.InlineWrapperEntity;
                    val = v.Value.ToString();
                };
                switch (val)
                {
                    case "0": color = Color.FromArgb(255, 128, 128, 255); break;
                    case "1": color = Color.FromArgb(255, 255, 128, 128); break;
                    case "2": color = Color.FromArgb(255, 255, 255, 192); break;
                    case "3": color = Color.FromArgb(255, 224, 255, 224); break;
                    case "4": color = Color.FromArgb(255, 192, 255, 192); break;
                    case "5": color = Color.FromArgb(255, 160, 255, 128); break;
                }
            };

            return new SolidColorBrush(color);
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object param,
            CultureInfo culture)
        {
            return null;
        }
    }

    public class MyColorStatus : IValueConverter
    {
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            //Color color = Colors.Transparent;
            

            /*if (value != null && value.GetType() == typeof(string))
            {
                string name = value.ToString();
                switch (name.ToLower())
                {
                    case "red": color = Colors.Red; break;
                    case "green": color = Colors.Green; break;
                    case "blue": color = Colors.Blue; break;
                    case "yellow": color = Colors.Yellow; break;
                    case "cyan": color = Colors.Cyan; break;
                    case "brown": color = Colors.Brown; break;
                    case "orange": color = Colors.Orange; break;
                    case "gray": color = Colors.Gray; break;
                    case "darkgray": color = Colors.DarkGray; break;
                    case "lightgray": color = Colors.LightGray; break;
                    case "magenta": color = Colors.Magenta; break;
                    case "purple": color = Colors.Purple; break;
                    case "white":
                    default: color = Colors.White; break;
                };
                color.A = 64; // Set opacity to 25%
            };*/

            //return new SolidColorBrush(color);

            Color color = Colors.Transparent;

            if (value == null || (bool)value == false)
            {
                return new SolidColorBrush(color);
            }
            else
            {
                color = Color.FromArgb(50,252,102,102);
                Color color2 = Color.FromArgb(100, 252, 174, 174);
                return new LinearGradientBrush(
                    new GradientStopCollection() { new GradientStop() { Color = color, Offset = 0 }, new GradientStop() { Color = color2, Offset = 1 } }, 90);
            }
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object param,
            CultureInfo culture)
        {
            return null;
        }
    }
}
