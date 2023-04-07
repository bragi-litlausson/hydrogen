using Hydrogen.ViewModels;

namespace Hydrogen.Core.Modules.UIManagement;

public abstract class PageViewModel : ViewModelBase
{
    protected IPageManager _pageManager;

    protected PageViewModel(IPageManager pageManager)
    {
        _pageManager = pageManager;
    }
}