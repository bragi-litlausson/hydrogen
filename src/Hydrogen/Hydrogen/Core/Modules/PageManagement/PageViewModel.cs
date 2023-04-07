namespace Hydrogen.Core.Modules.PageManagement;

public abstract class PageViewModel : ViewModel
{
    protected IPageManager _pageManager;

    protected PageViewModel(IPageManager pageManager)
    {
        _pageManager = pageManager;
    }
}