using BusinessData.ofWarehouse.Model;
using System.Net.Http.Json;

namespace BusinessView.ofUser
{
    public interface IWarehouser : IAuthorizeUser
    {
        
    }
    public class Warehouser : Employer,  IWarehouser, IDisposable
    {
        public HttpClient HttpClient { get; set; }
        private bool IsRoleCheck { get; set; }
        public Warehouser()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://warehouseserver.azurewebsites.net");
        }
        //public async Task<IEnumerable<Warehouse>> GetToListWarehouse()
        //{

        //}

        public virtual bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            HttpClient = null;
        }
    }
}
