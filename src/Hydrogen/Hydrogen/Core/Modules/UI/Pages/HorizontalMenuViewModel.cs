using System.Collections.Generic;
using Hydrogen.Core.Modules.PageManagement;
using Hydrogen.Core.Modules.UI.TemplatedControls.Models;
using Hydrogen.ViewModels;

namespace Hydrogen.Core.Modules.UI.Pages;

public sealed class HorizontalMenuViewModel : MenuViewModel
{
    public HorizontalMenuViewModel(string title, List<ButtonModel> buttonModels, IPageManager pageManager) 
        : base(title, buttonModels, pageManager)
    {
    }
}