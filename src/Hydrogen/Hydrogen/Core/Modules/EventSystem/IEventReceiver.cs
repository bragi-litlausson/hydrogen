namespace Hydrogen.Core.Modules.EventSystem;

public interface IEventReceiver
{
    void OnEventReceived(IEvent @event);
}