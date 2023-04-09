namespace Hydrogen.Core;

public interface IServiceContainer
{
    void RegisterService(IService service);
    void RegisterService<TInterface>(IService service) where TInterface : IService;
    void RemoveService(IService service);
    void RemoveService<TInterface>();
    TService? RetrieveService<TService>() where TService : class, IService;
}