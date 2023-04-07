using System;
using System.Collections.Generic;
using Hydrogen.Core.Modules.UIManagement;
using Hydrogen.Models;
using Hydrogen.ViewModels;

namespace Hydrogen.PageDefinitions;

public sealed class MainMenuPageDefinition : IPageDefinition
{
    public PageViewModel ConstructViewModel(IPageManager pageManager)
    {
        List<ButtonModel> buttons = new()
        {
            new("Vertical Menu", () => pageManager.MoveTo(null)),
            new("Click test", ()=>Console.WriteLine("Click Tested!")),
        };
        
        return new HorizontalMenuViewModel("Hydrogen", buttons, pageManager);
    }
}