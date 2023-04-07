using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Core;
using Hydrogen.Core.Modules.UIManagement;
using Hydrogen.Models;
using Hydrogen.PageDefinitions;

namespace Hydrogen.ViewModels;

public partial class MainViewModel : ViewModel, IPageManager
{
    [ObservableProperty] private ViewModel? _currentPage;

    private readonly Stack<IPageDefinition> _pageHistory = new();

    public void LoadFirstPage()
    {
        MoveTo(new MainMenuPageDefinition());
    }

    public void MoveTo(IPageDefinition pageDefinition, bool addToHistory = true)
    {
        var viewModel = pageDefinition.ConstructViewModel(this);
        CurrentPage = viewModel;
        
        if(addToHistory) _pageHistory.Push(pageDefinition);
    }

    public void MoveBack()
    {
        MoveTo(_pageHistory.Pop(), false);
    }

    public bool CanMoveBack()
    {
        return _pageHistory.Count != 0;
    }
}