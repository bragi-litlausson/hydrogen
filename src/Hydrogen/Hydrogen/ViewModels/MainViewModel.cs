using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Hydrogen.Core;
using Hydrogen.Core.Modules.EventSystem;
using Hydrogen.Core.Modules.PageManagement;
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
    private readonly IServiceManager _serviceManager;
    private readonly IMessageService _messageService;

    public MainViewModel(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
        _messageService = _serviceManager.RetrieveService<IMessageService>();
    }

    public void LoadFirstPage()
    {
        MoveTo(new MainMenuPageDefinition());
    }

    public void MoveTo(IPageDefinition pageDefinition, bool addToHistory = true)
    {
        var viewModel = pageDefinition.ConstructViewModel(this, _serviceManager);
        
        ReleaseViewModel();
        CurrentPage = viewModel;
        RegisterViewModel();
        
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

    private void ReleaseViewModel()
    {
        if(CurrentPage is not IMessageReceiver messageReceiver) return;
        
        _messageService.RemoveReceiver(messageReceiver);
    }

    private void RegisterViewModel()
    {
        if(CurrentPage is not IMessageReceiver messageReceiver) return;
        
        _messageService.RegisterReceiver(messageReceiver);
    }
}