using System;
using System.Collections.Generic;
using Hydrogen.Core.Modules.EventSystem;
using Hydrogen.Core.Modules.PageManagement;
using Hydrogen.Core.Modules.UI.Pages;
using Hydrogen.Core.Modules.UI.TemplatedControls.Models;
using Hydrogen.ViewModels;

namespace Hydrogen.PageDefinitions;

public sealed class PauseMenuPageDefinition : IPageDefinition, IMessageReceiver
{
    private IMessageSystem? _messageSystem;

    public PageViewModel ConstructViewModel(IPageManager pageManager)
    {
        _messageSystem ??= new MessageSystem();
        
        _messageSystem.RegisterReceiver(this);
       var buttons = new List<ButtonModel>
       {
           new("Move Back", pageManager.MoveBack),
           new("Test Click", () => Console.WriteLine("This also works!")),
           new("Msg Test", () => _messageSystem.Send(new MessageTest())),
       };

       return new VerticalMenuViewModel("Pause", buttons, pageManager);
    }

    // Only for testing purposes, definition should handle events
    private record MessageTest() : Message(MessageType.Application)
    {
    }

    public void OnEventReceived(IMessage message)
    {
        Console.WriteLine(message.ToString());
    }
}