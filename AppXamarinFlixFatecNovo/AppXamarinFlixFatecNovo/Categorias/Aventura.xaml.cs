using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppXamarinFlixFatecNovo.Filmes;

namespace AppXamarinFlixFatecNovo.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
                        

            logo.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Img.xamarin.png");

            btnAlladin.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Posters.alladin.jpg");
            btnCapitaMarvel.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Posters.capitamarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Posters.panteranegra.jpg");
            btnShazam.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Posters.shazam.jpg");
            btnDumbo.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Posters.dumbo.jpg");
            btnVef.Source = ImageSource.FromResource("AppXamarinFlixFatecNovo.Posters.vef.jpg");
        }

        private void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitaMarvel());

            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK :( ");
            }
        }
    }
}