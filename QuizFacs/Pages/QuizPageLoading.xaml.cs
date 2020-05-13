using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuizFacs.Services;
using SharedModels;
using Xamarin.Forms;

namespace QuizFacs.Pages
{
    public partial class QuizPageLoading : ContentPage
    {
        private readonly HttpServices httpService;

        CriarPerguntaModel model;
        int _id;
        public QuizPageLoading(int id)
        {
            InitializeComponent();
            httpService = new HttpServices();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            _id = id;
        }

        protected override async void OnAppearing()
        {
            this.model = await httpService.PegarPerguntaNaoRespondida(_id);

            if (this.model != null)
            {
                Navigation.InsertPageBefore(new QuizPage(this.model, _id), this);
                await Navigation.PopAsync();
            }
            else
            {
                Text.Text = "Não existe mais perguntas disponíveis!";
                Loading.IsVisible = false;
                NavigationPage.SetHasNavigationBar(this, true);
                NavigationPage.SetHasBackButton(this, true);
            }

        }
        
    }
}
