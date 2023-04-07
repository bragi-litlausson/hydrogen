using System;
using System.Collections.Generic;
using Hydrogen.Core.Modules.UIManagement;
using Hydrogen.Models;
using Hydrogen.ViewModels;

namespace Hydrogen.PageDefinitions;

public sealed class PauseMenuPageDefinition : IPageDefinition
{
    public PageViewModel ConstructViewModel(IPageManager pageManager)
    {
       var buttons = new List<ButtonModel>
       {
           new ButtonModel("Move Back", pageManager.MoveBack),
           new ButtonModel("Test Click", () => Console.WriteLine("This also works!")),
       };

       return new VerticalMenuViewModel("Pause", buttons, pageManager);
    }
}