using System;
using System.Collections.Generic;
using Hydrogen.Core.Extensions;
using Serilog;
using Serilog.Core;

namespace Hydrogen.Core.Modules.EventSystem;

public sealed class MessageService : IMessageService
{
    private readonly List<IMessageReceiver> _receivers = new();
    private readonly Queue<IMessage> _eventQueue = new();
    
    public void RegisterReceiver(IMessageReceiver messageReceiver)
    {
        _receivers.Add(messageReceiver);
        Log.Verbose($"Registered receiver {messageReceiver.GetType()}");
    }

    public void RemoveReceiver(IMessageReceiver messageReceiver)
    {
        _receivers.Remove(messageReceiver);
        Log.Verbose($"Removed receiver {messageReceiver.GetType()}");
    }

    /// <summary>
    /// Send event instantly to all registered receivers
    /// </summary>
    /// <param name="message"></param>
    public void Send(IMessage message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        
        Log.Debug($"Sending {message}");
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
        Log.Debug($"{message} added to the queue");
    }
}