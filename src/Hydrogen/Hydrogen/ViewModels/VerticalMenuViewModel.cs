using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public partial class VerticalMenuViewModel : MenuViewModelBase
{
    public VerticalMenuViewModel(string title, List<ButtonModel> buttonModels) : base(title, buttonModels)
    {
    }
}