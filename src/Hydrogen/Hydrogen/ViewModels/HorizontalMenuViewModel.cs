using System.Collections.Generic;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public sealed class HorizontalMenuViewModel : MenuViewModel
{
    public HorizontalMenuViewModel(string title, List<ButtonModel> buttonModels) : base(title, buttonModels)
    {
    }
}