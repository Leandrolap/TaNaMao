namespace QrApp_gerador;
using CommunityToolkit.Maui.Views;

public partial class PopupCriaQr : Popup
{
	public PopupCriaQr(string titulo, string link)
	{
		InitializeComponent();

        LblTitulo.Text = titulo;
        ImgQr.Value = link;
    }

    private void OnClickFechar(object sender, EventArgs e)
    {
        Close();
    }
}