using System;
using System.Globalization;
using Xamarin.Forms;

namespace XF47.Converters
{
    public class StringToBoolConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values is null || !targetType.IsAssignableFrom(typeof(bool)))
                return false;

            foreach(var value in values)
            {
                if (value is null)
                    return false;

                if (string.IsNullOrEmpty(value.ToString()))
                    return false;
            }

            return true;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => null;
    }
}
