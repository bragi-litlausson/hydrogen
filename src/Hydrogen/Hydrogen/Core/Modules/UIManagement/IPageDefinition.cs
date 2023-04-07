namespace Hydrogen.Core.Modules.UIManagement;

public interface IPageDefinition
{
    PageViewModel ConstructViewModel(IPageManager pageManager);
}