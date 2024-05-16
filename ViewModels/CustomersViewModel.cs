using System.Collections.ObjectModel;
using System.Data.Common;
using WiredBrainCoffee.CustomersApp.Data;
using WiredBrainCoffee.CustomersApp.Models;

namespace WiredBrainCoffee.CustomersApp.ViewModels
{
    public class CustomersViewModel : ViewModelBase
    {
        private readonly ICustomerDataProvider _dataProvider;
        private CustomerItemViewModel? _selectedCustomer;
        private NavigationSideEnum _navigationSide;

        public CustomersViewModel(ICustomerDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public ObservableCollection<CustomerItemViewModel> Customers { get; } = new();
        public CustomerItemViewModel? SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                RaisePropertyChanged();
            }
        }

        public NavigationSideEnum NavigationSide 
        { 
            get => _navigationSide;
            private set
            {
                _navigationSide = value;
                RaisePropertyChanged();
            }
        }

        public async Task LoadAsync()
        {
            if (Customers.Any())
            {
                return;
            }

            var customers = await _dataProvider.GetAllAsync();

            if (customers is not null)
            {
                foreach (var customer in customers)
                {
                    Customers.Add(new CustomerItemViewModel(customer));
                }
            }
        }

        internal void Add()
        {
            var customer = new Customer
            {
                FirstName = "new"
            };
            var viewModel = new CustomerItemViewModel(customer);
            Customers.Add(viewModel);
            SelectedCustomer = viewModel;
        }

        internal void MoveNavigation()
        {
            NavigationSide = NavigationSide == NavigationSideEnum.Left ? NavigationSideEnum.Right : NavigationSideEnum.Right;
        }

        public enum NavigationSideEnum
        {
            Left,
            Right
        }
    }
}
