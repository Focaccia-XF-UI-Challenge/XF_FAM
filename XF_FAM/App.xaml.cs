using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using XF_FAM.ViewModel;
using XF_FAM.Views;

namespace XF_FAM
{
    public partial class App : PrismApplication
    {
        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
            //var result =

            //if (!result.Success)
            //{
            //    System.Diagnostics.Debugger.Break();
            //}
        }
    }
}