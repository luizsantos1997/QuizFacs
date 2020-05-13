using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using QuizFacs.Services;
using Xamarin.Forms;

namespace QuizFacs.Pages
{
    public partial class RankingPage : ContentPage
    {
        private readonly HttpServices http;
        ObservableCollection<SharedModels.RankingModel> RankingUsers;

        public RankingPage()
        {
            InitializeComponent();
            http = new HttpServices();
            RankingUsers = new ObservableCollection<SharedModels.RankingModel>();
            RankingList.IsVisible = false;
            Loading.IsVisible = true;
            Loading.IsRunning = true;

        }
        protected override async void OnAppearing()
        {
            
            base.OnAppearing();
            var rankings = await http.GetTop10Ranking();
            if(rankings.Count == 0)
            {
                await DisplayAlert("Ranking", "Não há usúarios cadastrados", "Ok");
            }
            else
            {
                RankingUsers.Clear();
                foreach(var rank in rankings)
                {
                    RankingUsers.Add(rank);
                }

                RankingList.ItemsSource = RankingUsers;

            }
            RankingList.IsVisible = true;
            Loading.IsVisible = false;
            Loading.IsRunning = false;
        }
    }
}
