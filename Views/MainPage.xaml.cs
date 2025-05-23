﻿namespace Headstarter.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutUsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }

        private async void NavigateToSearchOfferCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchOfferPage());
        }
        private async void NavigateToJobOfferCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JobOfferPage());
        }
        private async void NavigateToCreateOfferCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOfferPage());
        }
        private async void NavigateToNewsCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsPage());
        }
        private async void NavigateToNewsTemplateCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsTemplatePage());
        }
        private async void NavigateToNotWorkerCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotWorkerPage());
        }
        private async void NavigateToNotRecruiterCommand(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotRecruiterPage());
        }

    }
}
