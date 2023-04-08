namespace Hydrogen.Core.Modules.EventSystem;

public abstract record Message(MessageType Type) : IMessage
{
    public bool Solved { get; private set; }
    
    public void MarkAsSolved()
    {
        Solved = true;
    }
}