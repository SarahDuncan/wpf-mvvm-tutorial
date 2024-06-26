﻿using WiredBrainCoffee.CustomersApp.Models;

namespace WiredBrainCoffee.CustomersApp.ViewModels
{
    public class CustomerItemViewModel : ValidationViewModelBase
    {
        private readonly Customer _model;

        public CustomerItemViewModel(Customer model)
        {
            _model = model;
        }

        public int Id => _model.Id;

        public string? FirstName
        {
            get => _model.FirstName;
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();
                if(string.IsNullOrEmpty(_model.FirstName))
                {
                    AddError("First name is required");
                }
                else
                {
                    ClearErrors();
                }
            }
        }

        public string? LastName
        {
            get => _model.LastName;
            set
            {
                _model.LastName = value;
                RaisePropertyChanged();
                if (string.IsNullOrEmpty(_model.LastName))
                {
                    AddError("Lastname is required");
                }
                else
                {
                    ClearErrors();
                }
            }
        }

        public bool IsDeveloper
        {
            get => _model.IsDeveloper;
            set
            {
                _model.IsDeveloper = value;
                RaisePropertyChanged();
            }
        }
    }
}
