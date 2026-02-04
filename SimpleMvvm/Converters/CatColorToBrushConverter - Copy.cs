using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace SimpleMvvm.Converters
{
    public class CatColorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is CatColor catColor))
            {
                return Brushes.Transparent;
            }

            return catColor.ColorValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Brush brushValue))
            {
                return new CatColor(Brushes.Transparent, "Unknown Color");
            }

            // Find the matching CatColor
            foreach (var color in CatColor.AllColors)
            {
                if (color.ColorValue == brushValue)
                {
                    return color;
                }
            }

            return new CatColor(Brushes.Transparent, "Unknown Color");
        }
    }
}