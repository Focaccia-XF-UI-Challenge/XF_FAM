using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace XF_FAM.ViewModels
{
    public class RegistPhonePageViewModel : BindableBase, INavigatedAware
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand RegisterConfirmCommand { get; set; }
        public List<Country> Countrys { get; set; }

        public RegistPhonePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            //get Data By Url:https://raw.githubusercontent.com/linssen/country-flag-icons/master/countries.json

            Countrys = new List<Country>()
            {
                new Country() {Key = 1, Value = "A"},
                new Country() {Key = 1, Value = "B"},
                new Country() {Key = 1, Value = "C"}
            };

            RegisterConfirmCommand = new DelegateCommand(RegisterConfrimAction);
        }

        private async void RegisterConfrimAction()
        {
            await _navigationService.NavigateAsync("RegistConfirmPage");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }

    public class Country
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public string Picture { get; set; }
    }
}