using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TZ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = new NavigationPage(new MainPage());
            page.BarBackgroundColor = Color.Aquamarine;
            page.BarTextColor = Color.Black;
            page.Title = "MainPage";
            MainPage = page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
