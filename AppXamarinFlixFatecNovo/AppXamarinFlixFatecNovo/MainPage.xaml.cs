using System;
using Xamarin.Forms;

using AppXamarinFlixFatecNovo.Categorias;

namespace AppXamarinFlixFatecNovo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Img.xamarin.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Aventura());

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok :( ");
            }
        }
    }
}
