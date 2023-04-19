using LSPDFRManager.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace LSPDFRManager.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class LSPDFRPage : Page
{
    public LSPDFRViewModel ViewModel
    {
        get;
    }

    public LSPDFRPage()
    {
        ViewModel = App.GetService<LSPDFRViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
