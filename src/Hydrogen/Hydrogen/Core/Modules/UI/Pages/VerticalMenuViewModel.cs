using System;
using System.Collections.Generic;
using Hydrogen.Core.Modules.EventSystem;
using Hydrogen.Core.Modules.PageManagement;
using Hydrogen.Core.Modules.UI.TemplatedControls.Models;
using Hydrogen.ViewModels;

namespace Hydrogen.Core.Modules.UI.Pages;

public sealed class VerticalMenuViewModel : MenuViewModel, IMessageReceiver
{
    public VerticalMenuViewModel(string title, List<ButtonModel> buttonModels, IPageManager pageManager) 
        : base(title, buttonModels, pageManager)
    {
    }

    public void OnEventReceived(IMessage message)
    {
        Console.WriteLine(message.ToString());
    }
}