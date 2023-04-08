namespace Hydrogen.Core.Modules.EventSystem;

public interface IEventSystem
{
    void RegisterReceiver(IEventReceiver eventReceiver);
    void RemoveReceiver(IEventReceiver eventReceiver);

    void Send(IEvent @event);
    void AddToQueue(IEvent @event);
}