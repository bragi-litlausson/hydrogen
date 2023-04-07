namespace Hydrogen.Core.Modules.UIManagement;

public interface IPageDefinition
{
    static abstract PageViewModel Construct(IPageManager pageManager);
}