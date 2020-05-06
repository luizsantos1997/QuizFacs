using System;
using QuizFacs.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizFacs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());//new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            var newPage = new HomePage();
            NavigationPage.SetHasNavigationBar(newPage, false);
            NavigationPage.SetHasBackButton(newPage, false);
            App.Current.MainPage = new NavigationPage(newPage);
        }
    }
}
