using System.Collections.Generic;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public sealed class HorizontalMenuViewModel : MenuViewModelBase
{
    public HorizontalMenuViewModel(string title, List<ButtonModel> buttonModels) : base(title, buttonModels)
    {
    }
}