namespace Hydrogen.Core.Modules.EventSystem;

public interface IMessageReceiver
{
    void OnEventReceived(IMessage message);
}