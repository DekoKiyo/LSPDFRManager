using CommunityToolkit.WinUI.UI.Animations;

using LSPDFRManager.Contracts.Services;
using LSPDFRManager.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace LSPDFRManager.Views;

public sealed partial class InstalledPluginsDetailPage : Page
{
    public InstalledPluginsDetailViewModel ViewModel
    {
        get;
    }

    public InstalledPluginsDetailPage()
    {
        ViewModel = App.GetService<InstalledPluginsDetailViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        base.OnNavigatingFrom(e);
        if (e.NavigationMode == NavigationMode.Back)
        {
            var navigationService = App.GetService<INavigationService>();

            if (ViewModel.Item != null)
            {
                navigationService.SetListDataItemForNextConnectedAnimation(ViewModel.Item);
            }
        }
    }
}
