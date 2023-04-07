using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Core;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public partial class MainViewModel : ViewModel
{
    [ObservableProperty] private ViewModel? _currentPage;

    public void LoadFirstPage()
    {
        CurrentPage = ConstructTestHorizontalMenuViewModel();
    }

    private static ViewModel ConstructTestHorizontalMenuViewModel()
    {
        List<ButtonModel> buttons = new List<ButtonModel>
        {
            new("Option1", () => Console.WriteLine("Click 1")),
            new("Option2", () => Console.WriteLine("Click 2")),
        };

        return new HorizontalMenuViewModel("Test menu", buttons);
    }
}