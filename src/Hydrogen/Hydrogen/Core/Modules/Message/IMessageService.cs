namespace Hydrogen.Core.Modules.EventSystem;

public interface IMessageService : IService
{
    void RegisterReceiver(IMessageReceiver messageReceiver);
    void RemoveReceiver(IMessageReceiver messageReceiver);

    void Send(IMessage message);
    void AddToQueue(IMessage message);
}