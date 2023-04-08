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

    public void RemoveService(IService service)
    {
        if (!_services.ContainsKey(service.GetType()))
        {
            throw new ArgumentException($"{service.GetType()} not found");
        }

        _services.Remove(service.GetType());
    }

    public IService? RetrieveService<TService>() where TService : class, IService
    {
        return !_services.ContainsKey(typeof(TService)) ? null : _services[typeof(TService)];
    }
}