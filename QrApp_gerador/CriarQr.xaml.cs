using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;

namespace QrApp_gerador;

public partial class CriarQr : ContentPage
{
	public CriarQr()
	{
		InitializeComponent();
    }

    private void OnClickGerar(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TxtTitulo.Text) || string.IsNullOrEmpty(EdTexto.Text))
        {
            var toast = Toast.Make("Existe campos vazios", CommunityToolkit.Maui.Core.ToastDuration.Long, 16);
            toast.Show();
        }
        else
        {
            this.ShowPopup(new PopupCriaQr(TxtTitulo.Text, EdTexto.Text));
        }
    }
}