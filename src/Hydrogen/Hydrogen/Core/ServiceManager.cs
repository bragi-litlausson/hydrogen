using System;
using System.Collections.Generic;

namespace Hydrogen.Core;

public sealed class ServiceManager : IServiceManager
{
    private readonly Dictionary<Type, IService> _services = new();
    
    public void RegisterService(IService service)
    {
        if (_services.ContainsKey(service.GetType()))
        {
            throw new ArgumentException($"{service.GetType()} already registered");
        }

        _services[service.GetType()] = service;
    }

    public void RegisterService<TInterface>(IService service) where TInterface : IService
    {
        if(_services.ContainsKey(typeof(TInterface)))
        {
            throw new ArgumentException($"{service.GetType()} already registered");
        }

        _services[typeof(TInterface)] = service;
    }

    public void RemoveService(IService service)
    {
        if (!_services.ContainsKey(service.GetType()))
        {
            throw new ArgumentException($"{service.GetType()} not found");
        }

        _services.Remove(service.GetType());
    }

    public void RemoveService<TInterface>()
    {
        if (!_services.ContainsKey(typeof(TInterface)))
        {
            throw new ArgumentException($"{typeof(TInterface)} not found");
        }

        _services.Remove(typeof(TInterface));
    }

    public TService? RetrieveService<TService>() where TService : class, IService
    {
        return !_services.ContainsKey(typeof(TService)) ? null : _services[typeof(TService)] as TService;
    }
}