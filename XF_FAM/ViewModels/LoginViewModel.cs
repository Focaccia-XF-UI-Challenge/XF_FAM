using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace XF_FAM.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand ClickCommand { get; set; }
        public DelegateCommand RegistCommand { get; set; }

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ClickCommand = new DelegateCommand(SecondPageAction);
            RegistCommand = new DelegateCommand(RegistPageAction);
        }

        private async void SecondPageAction()
        {
            await _navigationService.NavigateAsync("MainPage");
        }

        private async void RegistPageAction()
        {
            await _navigationService.NavigateAsync("RegistPhonePage");
        }
    }
}