using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace XF_FAM.ViewModel
{
public class LoginViewModel : BindableBase
{
    private readonly INavigationService _navigationService;
    public DelegateCommand SecondPageCommand { get; set; }

    public LoginViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;

        SecondPageCommand = new DelegateCommand(SecondPageAction);
    }

    private async void SecondPageAction()
    {
        await _navigationService.NavigateAsync("MainPage");
    }
}
}
