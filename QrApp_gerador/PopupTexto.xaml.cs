namespace QrApp_gerador;
using CommunityToolkit.Maui.Views;

public partial class PopupTexto : Popup
{
	public PopupTexto(string descricao)
	{
		InitializeComponent();

		QrTexto.Text = descricao;
	}

    private void OnClickFechar(object sender, EventArgs e)
    {
        Close();
    }
}