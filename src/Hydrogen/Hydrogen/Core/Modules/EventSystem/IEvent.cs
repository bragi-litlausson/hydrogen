namespace Hydrogen.Core.Modules.EventSystem;

public interface IEvent
{
    public EventType Type { get; }
    public bool Solved { get; }

    void MarkAsSolved();
}