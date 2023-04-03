using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public abstract partial class MenuViewModelBase : ViewModelBase
{
    [ObservableProperty] private string _title;

    public MenuViewModelBase(string title, List<ButtonModel> buttonModels)
    {
        _title = title;
        ButtonModels = buttonModels;
    }
    
    public List<ButtonModel> ButtonModels { get; init; }
}