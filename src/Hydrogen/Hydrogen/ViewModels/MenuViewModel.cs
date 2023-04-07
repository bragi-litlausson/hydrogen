using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Core;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public abstract partial class MenuViewModel : ViewModel
{
    [ObservableProperty] private string _title;

    public MenuViewModel(string title, List<ButtonModel> buttonModels)
    {
        _title = title;
        ButtonModels = buttonModels;
    }
    
    public List<ButtonModel> ButtonModels { get; init; }
}