using LSPDFRManager.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace LSPDFRManager.Views;

public sealed partial class GeneralPage : Page
{
    public GeneralViewModel ViewModel
    {
        get;
    }

    public GeneralPage()
    {
        ViewModel = App.GetService<GeneralViewModel>();
        InitializeComponent();
    }
}
