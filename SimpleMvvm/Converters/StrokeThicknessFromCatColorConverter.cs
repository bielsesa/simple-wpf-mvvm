using System;
using System.Globalization;
using System.Windows.Data;

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

            if (catColor.ColorName.Equals(CatColor.White.ColorName))
            {
                return 1;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}