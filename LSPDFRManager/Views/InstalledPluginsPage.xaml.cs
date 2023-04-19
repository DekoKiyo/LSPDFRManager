using LSPDFRManager.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace LSPDFRManager.Views;

public sealed partial class InstalledPluginsPage : Page
{
    public InstalledPluginsViewModel ViewModel
    {
        get;
    }

    public InstalledPluginsPage()
    {
        ViewModel = App.GetService<InstalledPluginsViewModel>();
        InitializeComponent();
    }
}
