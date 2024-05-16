using System.Globalization;
using System.Windows.Data;
using static WiredBrainCoffee.CustomersApp.ViewModels.CustomersViewModel;

namespace WiredBrainCoffee.CustomersApp.Converter
{
    public class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var navigationSide = (NavigationSideEnum)value;
            return navigationSide == NavigationSideEnum.Left ? 0 : 2; // <- value for Grid.Column
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
