namespace Hydrogen.Core.Modules.PageManagement;

public interface IPageDefinition
{
    PageViewModel ConstructViewModel(IPageManager pageManager, IServiceContainer serviceContainer);
}