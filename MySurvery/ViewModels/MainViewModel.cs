using System;
using System.Windows.Input;
using MySurvery.Core.Services;
using Xamarin.Forms;

namespace MySurvery.Core.ViewModels
{
    public class MainViewModel
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
            LogoutCommand = new Command(Logout);
        }

        private void Logout()
        {
            App.IsUserLoggedIn = false;
            _navigationService.NavigateModalAsync(PageNames.LoginPage);
        }

        public ICommand LogoutCommand { private set; get; }
    }
}
