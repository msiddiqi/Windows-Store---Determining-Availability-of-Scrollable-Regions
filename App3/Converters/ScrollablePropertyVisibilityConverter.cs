using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ScrollViewerApp.Converters
{
    public class ScrollablePropertyVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var visibility = (System.Convert.ToInt32(value) == 0) ? Visibility.Collapsed : Visibility.Visible;

            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
