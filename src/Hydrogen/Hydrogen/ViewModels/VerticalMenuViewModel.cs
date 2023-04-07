using System.Collections.Generic;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public sealed class VerticalMenuViewModel : MenuViewModel
{
    public VerticalMenuViewModel(string title, List<ButtonModel> buttonModels) : base(title, buttonModels)
    {
    }
}