﻿using System;
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
    
    /// <summary>
    /// Stores page definition to add to page history stack on transition
    /// </summary>
    private IPageDefinition? _currentDefinition;

    public void LoadFirstPage()
    {
        MoveTo(new MainMenuPageDefinition());
    }

    public void MoveTo(IPageDefinition pageDefinition, bool addToHistory = true)
    {
        var viewModel = pageDefinition.ConstructViewModel(this);
        CurrentPage = viewModel;
        
        
        if(_currentDefinition is not null) _pageHistory.Push(_currentDefinition);
        if(addToHistory) _currentDefinition = pageDefinition;
    }

    public void MoveBack()
    {
        _currentDefinition = _pageHistory.Pop();
        
        MoveTo(_currentDefinition, false);
        
        _currentDefinition = null;
    }

    public bool CanMoveBack()
    {
        return _pageHistory.Count != 0;
    }
}