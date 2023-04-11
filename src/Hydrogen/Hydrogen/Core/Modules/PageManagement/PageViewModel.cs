using Serilog;

namespace Hydrogen.Core.Modules.PageManagement;

public abstract class PageViewModel : ViewModel
{
    protected IPageManager _pageManager;

    protected PageViewModel(IPageManager pageManager)
    {
        Log.Verbose($"{GetType().Name} created");
        _pageManager = pageManager;
    }
}