using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofCommon.ofEmployer;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofGeneric
{
    public interface IActorViewService<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(string Id);
        Task<T> Post(T t);
        Task Delete(string Id);
        Task Update(string Id, T t);
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
