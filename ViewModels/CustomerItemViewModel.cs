using WiredBrainCoffee.CustomersApp.Models;

namespace WiredBrainCoffee.CustomersApp.ViewModels
{
    public class CustomerItemViewModel : ViewModelBase
    {
        private readonly Customer _model;

        public CustomerItemViewModel(Customer model)
        {
            _model = model;
        }

        public int Id => _model.Id;

        public bool IsDeveloper
        {
            get { return _model.IsDeveloper; }
            set 
            { 
                _model.IsDeveloper = value;
                RaisePropertyChanged();
            }
        }

        public string? FirstName
        {
            get { return _model.FirstName; }
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();
            }
        }

        public string? LastName
        {
            get { return _model.LastName; }
            set 
            { 
                _model.LastName = value; 
                RaisePropertyChanged();
            }
        }
    }
}
