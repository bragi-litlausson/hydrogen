namespace Hydrogen.Core.Modules.EventSystem;

public abstract record Event(EventType Type) : IEvent
{
    public bool Solved { get; private set; }
    
    public void MarkAsSolved()
    {
        Solved = true;
    }
}