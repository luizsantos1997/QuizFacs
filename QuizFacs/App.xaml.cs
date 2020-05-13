using System;
using QuizFacs.Data;
using QuizFacs.Pages;
using QuizFacs.Services;
using SharedModels;
using Xamarin.Forms;

namespace QuizFacs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            using (var sql = new SqLiteServices())
            {
                UsuarioSQLITE data;
                try
                {
                    data = sql.GetUserSaved();
                    MainPage = new NavigationPage(new HomePage(data));//new LoginPage();

                }
                catch (Exception)
                {
                    sql.CriarBancoDeDados();
                    MainPage = new LoginPage();
                }
            }
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            
        }
    }
}
