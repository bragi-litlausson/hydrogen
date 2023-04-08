namespace Hydrogen.Core.Modules.EventSystem;

public interface IMessageSystem
{
    void RegisterReceiver(IMessageReceiver messageReceiver);
    void RemoveReceiver(IMessageReceiver messageReceiver);

    void Send(IMessage message);
    void AddToQueue(IMessage message);
}