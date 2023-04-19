﻿using CommunityToolkit.Mvvm.ComponentModel;

using LSPDFRManager.Contracts.ViewModels;
using LSPDFRManager.Core.Contracts.Services;
using LSPDFRManager.Core.Models;

namespace LSPDFRManager.ViewModels;

public class InstalledPluginsDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder? _item;

    public SampleOrder? Item
    {
        get => _item;
        set => SetProperty(ref _item, value);
    }

    public InstalledPluginsDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
