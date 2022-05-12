using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofGeneric
{
    public interface IActorViewService<T> where T : class
    {
        Task<IEnumerable<T>?> GetsAsync();
        Task<T?> GetByIdAsync(string id);
        Task<T?> PostAsync(T entity);
        Task DeleteAsync(string dtoname, string id);
        Task<T?> PutAsync(T entity);
    }
    public interface IEmployerViewService<T> where T : EmployerEntity
    {
        
    }
    public interface IEmployeeViewServcie<T> where T : EmployeeEntity
    {

    }
    public interface IPlatformViewService<T> where T : PlatformEntity
    {

    }
}
