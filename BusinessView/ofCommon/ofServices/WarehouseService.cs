using BusinessView.ofCommon.ofInterface;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofCommon.ofServices
{
    public class WarehouseService : IViewService<EmployerWarehouse>, IDisposable
    {
        private HttpClient _httpClient;
        public WarehouseService()
        {
            _httpClient = new HttpClient();
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        public Task<IEnumerable<EmployerWarehouse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWarehouse> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
