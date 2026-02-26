using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace mangaReader.Converters
{
    public class NavigationColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int index && parameter is string paramStr)
            {
                if (int.TryParse(paramStr, out int targetIndex))
                {
                    return index == targetIndex ? new SolidColorBrush(Color.Parse("#1976D2")) : new SolidColorBrush(Color.Parse("#616161"));
                }
            }
            return new SolidColorBrush(Color.Parse("#616161"));
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
