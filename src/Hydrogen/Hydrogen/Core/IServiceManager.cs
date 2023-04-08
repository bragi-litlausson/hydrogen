namespace Hydrogen.Core;

public interface IServiceManager
{
    void RegisterService(IService service);
    void RemoveService(IService service);
    IService? RetrieveService<TService>() where TService : class, IService;
}