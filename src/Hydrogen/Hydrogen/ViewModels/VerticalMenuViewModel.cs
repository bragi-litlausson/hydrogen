using System.Collections.Generic;
using Hydrogen.Core.Modules.UIManagement;
using Hydrogen.Models;

namespace Hydrogen.ViewModels;

public sealed class VerticalMenuViewModel : MenuViewModel
{
    public VerticalMenuViewModel(string title, List<ButtonModel> buttonModels, IPageManager pageManager) 
        : base(title, buttonModels, pageManager)
    {
    }
}