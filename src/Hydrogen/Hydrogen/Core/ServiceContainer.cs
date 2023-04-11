using System;
using System.Collections.Generic;
using Hydrogen.Core.Modules.EventSystem;
using Serilog;

namespace Hydrogen.Core;

public sealed class ServiceContainer : IServiceContainer
{
    private readonly Dictionary<Type, IService> _services = new();
    private readonly IMessageService _messageService;

    public ServiceContainer(IMessageService messageService)
    {
        _messageService = messageService;
        _services[typeof(IMessageService)] = messageService;
        
    }
    
    public void RegisterService(IService service)
    {
        if (_services.ContainsKey(service.GetType()))
        {
            throw new ArgumentException($"ServiceContainer: {service.GetType()} already registered");
        }

        if(service is IMessageReceiver receiver) _messageService.RegisterReceiver(receiver); 
        
        _services[service.GetType()] = service;
        Log.Debug($"ServiceContainer: {service.GetType()} registered");
    }

    public void RegisterService<TInterface>(IService service) where TInterface : IService
    {
        if(_services.ContainsKey(typeof(TInterface)))
        {
            throw new ArgumentException($"{service.GetType()} already registered");
        }

        _services[typeof(TInterface)] = service;
        Log.Debug($"ServiceContainer: {service.GetType()} registered as {typeof(TInterface)}");
    }

    public void RemoveService(IService service)
    {
        if (!_services.ContainsKey(service.GetType()))
        {
            throw new ArgumentException($"{service.GetType()} not found");
        }

        _services.Remove(service.GetType());
        Log.Debug($"ServiceContainer: {service.GetType()} removed");
    }

    public void RemoveService<TInterface>()
    {
        if (!_services.ContainsKey(typeof(TInterface)))
        {
            throw new ArgumentException($"{typeof(TInterface)} not found");
        }

        _services.Remove(typeof(TInterface));
        Log.Debug($"ServiceContainer: {typeof(TInterface)} removed");
    }

    public TService? RetrieveService<TService>() where TService : class, IService
    {
        return !_services.ContainsKey(typeof(TService)) ? null : _services[typeof(TService)] as TService;
    }
}