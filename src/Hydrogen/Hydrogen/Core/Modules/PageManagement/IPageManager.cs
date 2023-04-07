namespace Hydrogen.Core.Modules.PageManagement;

public interface IPageManager
{
    // Potentially change to generic method?
    // Can't remember right now if static method can be accessed thru type parameter 
    public void MoveTo(IPageDefinition pageDefinition, bool addToHistory = true);
    public void MoveBack();
    public bool CanMoveBack();
}