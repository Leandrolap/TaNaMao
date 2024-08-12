using Microsoft.Maui.Animations;

namespace QrApp_gerador
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTappedCriar(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new CriarQr());
        }

        private async void OnTappedLer(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new LerQr());
        }

        private async void OnClickSobre(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}
