﻿using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Core;
using Hydrogen.Core.Modules.EventSystem;
using Hydrogen.Core.Modules.PageManagement;
using Hydrogen.PageDefinitions;
using Serilog;

namespace Hydrogen.ViewModels;

public partial class MainViewModel : ViewModel, IPageManager
{
    [ObservableProperty] private ViewModel? _currentPage;
    
    private readonly Stack<IPageDefinition> _pageHistory = new();
    
    /// <summary>
    /// Stores page definition to add to page history stack on transition
    /// </summary>
    private IPageDefinition? _currentDefinition;
    private readonly IServiceContainer _serviceContainer;
    private readonly IMessageService _messageService;

    public MainViewModel(IServiceContainer serviceContainer)
    {
        Log.Verbose($"Main view model created");
        _serviceContainer = serviceContainer;
        var messageService = _serviceContainer.RetrieveService<IMessageService>();

        _messageService = messageService ?? throw new NullReferenceException("Message service not found!");
    }

    public void LoadFirstPage()
    {
        Log.Information($"MainViewModel: Loading first page: Main Menu");
        MoveTo(new MainMenuPageDefinition());
    }

    public void MoveTo(IPageDefinition pageDefinition, bool addToHistory = true)
    {
        var viewModel = pageDefinition.ConstructViewModel(this, _serviceContainer);
        
        ReleaseViewModel();
        CurrentPage = viewModel;
        RegisterViewModel();
        
        if(_currentDefinition is not null) _pageHistory.Push(_currentDefinition);
        if(addToHistory) _currentDefinition = pageDefinition;
        Log.Information($"MainViewModel: Moving to {pageDefinition.GetType()}");
    }

    public void MoveBack()
    {
        Log.Information("MainViewModel: Move back");
        _currentDefinition = _pageHistory.Pop();
        
        MoveTo(_currentDefinition, false);
        
        _currentDefinition = null;
    }

    public bool CanMoveBack()
    {
        return _pageHistory.Count != 0;
    }

    private void ReleaseViewModel()
    {
        if(CurrentPage is not IMessageReceiver messageReceiver) return;
        
        _messageService.RemoveReceiver(messageReceiver);
        Log.Verbose($"MainViewModel: Released {CurrentPage.GetType()}");
    }

    private void RegisterViewModel()
    {
        if(CurrentPage is not IMessageReceiver messageReceiver) return;
        
        _messageService.RegisterReceiver(messageReceiver);
        Log.Verbose($"MainViewModel: {CurrentPage.GetType()} registered");
    }
}