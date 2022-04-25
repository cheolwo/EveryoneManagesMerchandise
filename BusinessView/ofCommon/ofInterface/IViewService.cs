using BusinessView.ofGeneric;

namespace BusinessView.ofCommon.ofInterface
{
    public interface IViewService<T> where T : IDTO
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
    }
    public interface IViewService
    {

    }

}
