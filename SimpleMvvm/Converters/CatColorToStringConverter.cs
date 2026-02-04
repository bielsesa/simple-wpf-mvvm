using System;
using System.Globalization;
using System.Windows.Data;

namespace SimpleMvvm.Converters
{
    public class CatColorToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is CatColor catColor))
            {
                return "This cat is of an unknown color... wow!";
            }

            return $"This cat color is {catColor.ColorName.ToLowerInvariant()}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}