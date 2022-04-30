using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofCommon.ofEmployer;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofGeneric
{
    public interface IActorViewService<T> where T : class
    {
        Task<IEnumerable<T>?> GetAsync();
        Task<T> GetByIdAsync(string Id);
        Task<T> PostAsync(T t);
        Task DeleteAsync(string Id);
        Task<T> PutAsync(T t);
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
