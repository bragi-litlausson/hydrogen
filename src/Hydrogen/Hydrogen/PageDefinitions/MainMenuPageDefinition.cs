using System;
using System.Collections.Generic;
using Hydrogen.Core;
using Hydrogen.Core.Modules.PageManagement;
using Hydrogen.Core.Modules.UI.Pages;
using Hydrogen.Core.Modules.UI.TemplatedControls.Models;
using Serilog;

namespace Hydrogen.PageDefinitions;

public sealed class MainMenuPageDefinition : IPageDefinition
{
    public PageViewModel ConstructViewModel(IPageManager pageManager, IServiceContainer serviceContainer)
    {
        Log.Debug($"MainMenu Page Definition: Constructing ViewModel");
        
        List<ButtonModel> buttons = new()
        {
            new("Vertical Menu", () => pageManager.MoveTo(new PauseMenuPageDefinition())),
            new("Click! ", ()=>Console.WriteLine("Click Tested!")),
            new("Click test", ()=>Console.WriteLine("Click Tested!")),
            new("Click test", ()=>Console.WriteLine("Click Tested!")),
        };
        
        return new HorizontalMenuViewModel("Hydrogen", buttons, pageManager);
    }
}