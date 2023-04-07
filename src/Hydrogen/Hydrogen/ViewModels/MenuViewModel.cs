using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Core;
using Hydrogen.Core.Modules.UIManagement;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public abstract partial class MenuViewModel : PageViewModel
{
    [ObservableProperty] private string _title;

    public MenuViewModel(string title, List<ButtonModel> buttonModels, IPageManager pageManager) : base(pageManager)
    {
        _title = title;
        ButtonModels = buttonModels;
    }
    
    public List<ButtonModel> ButtonModels { get; init; }
}