using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlixFatecNovo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage())
            {
               // BarBackgroundColor = Color.FromHex("#2f2f30"),
                // BarTextColor = Color.FromHex("#999999")
            };
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
