using System;
using System.Collections.Generic;
using Hydrogen.Core;
using Hydrogen.Core.Modules.EventSystem;
using Hydrogen.Core.Modules.PageManagement;
using Hydrogen.Core.Modules.UI.Pages;
using Hydrogen.Core.Modules.UI.TemplatedControls.Models;
using Serilog;

namespace Hydrogen.PageDefinitions;

public sealed class PauseMenuPageDefinition : IPageDefinition
{

    public PageViewModel ConstructViewModel(IPageManager pageManager, IServiceContainer serviceContainer)
    {
        Log.Debug($"Pause Menu Page Definition: Constructing ViewModel");

        var messageSystem = serviceContainer.RetrieveService<IMessageService>() ?? throw new ArgumentNullException("serviceManager.RetrieveService<IMessageService>()");
        
       var buttons = new List<ButtonModel>
       {
           new("Move Back", pageManager.MoveBack),
           new("Test Click", () => Console.WriteLine("This also works!")),
           new("Msg Test", () => messageSystem.Send(new MessageTest())),
       };

       var viewModel = new VerticalMenuViewModel("Pause", buttons, pageManager);
       return viewModel;
    }

    // Only for testing purposes, definition should handle events
    private record MessageTest() : Message(MessageType.Application);
}