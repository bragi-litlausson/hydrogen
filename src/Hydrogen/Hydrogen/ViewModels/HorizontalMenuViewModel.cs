using System.Collections.Generic;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public sealed class HorizontalMenuViewModel : ViewModelBase
{
    public HorizontalMenuViewModel(string title, List<ButtonModel> buttonModels)
    {
        Title = title;
        ButtonModels = buttonModels;
    }

    public string Title { get; init; } = "Horizontal Menu";
    public List<ButtonModel> ButtonModels { get; init; }
}