using System;
using System.Globalization;
using System.Windows.Data;

using SimpleMvvm.Cat;

namespace SimpleMvvm.Converters
{
    public class StrokeThicknessFromCatColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is CatColor catColor))
            {
                throw new ArgumentException("Invalid color", nameof(value));
            }

            return catColor.ColorName.Equals(CatColor.White.ColorName) ? 1 : 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}