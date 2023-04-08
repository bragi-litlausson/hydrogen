namespace Hydrogen.Core.Modules.EventSystem;

public interface IMessage
{
    public MessageType Type { get; }
    public bool Solved { get; }

    void MarkAsSolved();
}