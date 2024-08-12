using Camera.MAUI;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Maui.Views;
using System.Diagnostics;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace QrApp_gerador;

public partial class LerQr : ContentPage
{
    Uri uri;

    String linkWeb = "";

    public LerQr()
	{
		InitializeComponent();
        BtnLink.IsEnabled = false;
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        foreach (var barcode in e.Results)
        {
            string Web = barcode.Value;
            linkWeb = Web;
        }

        MainThread.BeginInvokeOnMainThread(() =>
        {
            cameraBarcodeReaderView.IsDetecting = false;

            var toast = Toast.Make("Sucesso", CommunityToolkit.Maui.Core.ToastDuration.Short, 14);
            toast.Show();
            Texto();
        });
    }

    private async void OnClickAbrir(object sender, EventArgs e)
    {
        uri = new Uri(linkWeb);
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        BtnLink.IsVisible = false;
        BtnNovoLink.IsEnabled = true;
        BtnNovoLink.IsVisible = true;
    }

    private void Texto ()
    {
        try
        {
            uri = new Uri(linkWeb);
            BtnLink.IsEnabled = true;
            BtnLink.IsVisible = true;

        }
        catch (Exception)
        {
            this.ShowPopup(new PopupTexto(linkWeb));
            BtnNovoLink.IsVisible = true;
            BtnNovoLink.IsEnabled = true;
        }
    }

    private void OnClickedNovaLeitura(object sender, EventArgs e)
    {
        cameraBarcodeReaderView.IsDetecting = true;
        BtnLink.IsEnabled = false;
        BtnLink.IsVisible = false;
        BtnNovoLink.IsVisible = false;
        BtnNovoLink.IsEnabled = false;
    }
}