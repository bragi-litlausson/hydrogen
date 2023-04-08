using System;
using System.Collections.Generic;
using Hydrogen.Core.Extensions;

namespace Hydrogen.Core.Modules.EventSystem;

public sealed class MessageSystem : IMessageSystem
{
    private List<IMessageReceiver> _receivers;
    private Queue<IMessage> _eventQueue;
    
    public void RegisterReceiver(IMessageReceiver messageReceiver)
    {
        _receivers.Add(messageReceiver);
    }

    public void RemoveReceiver(IMessageReceiver messageReceiver)
    {
        _receivers.Remove(messageReceiver);
    }

    /// <summary>
    /// Send event instantly to all registered receivers
    /// </summary>
    /// <param name="message"></param>
    public void Send(IMessage message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        
        _receivers.Foreach(e => e.OnEventReceived(message));
    }

    
    /// <summary>
    /// Doesn't work right now, requires real time clock
    /// </summary>
    /// <param name="message"></param>
    public void AddToQueue(IMessage message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        
        _eventQueue.Enqueue(message);
    }
}