using System;
using System.Collections.Generic;
using Hydrogen.Core.Extensions;

namespace Hydrogen.Core.Modules.EventSystem;

public sealed class EventSystem : IEventSystem
{
    private List<IEventReceiver> _receivers;
    private Queue<IEvent> _eventQueue;
    
    public void RegisterReceiver(IEventReceiver eventReceiver)
    {
        _receivers.Add(eventReceiver);
    }

    public void RemoveReceiver(IEventReceiver eventReceiver)
    {
        _receivers.Remove(eventReceiver);
    }

    /// <summary>
    /// Send event instantly to all registered receivers
    /// </summary>
    /// <param name="event"></param>
    public void Send(IEvent @event)
    {
        if (@event is null) throw new ArgumentNullException(nameof(@event));
        
        _receivers.Foreach(e => e.OnEventReceived(@event));
    }

    
    /// <summary>
    /// Doesn't work right now, requires real time clock
    /// </summary>
    /// <param name="event"></param>
    public void AddToQueue(IEvent @event)
    {
        if (@event is null) throw new ArgumentNullException(nameof(@event));
        
        _eventQueue.Enqueue(@event);
    }
}