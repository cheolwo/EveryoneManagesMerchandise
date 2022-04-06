using BusinessData.ofWarehouse.Model;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofUser
{
    public class AuthorizationUser : User, IAuthorizeUser
    {
        private HttpClient AuthorizeHttpClient;
        public AuthorizationUser()
            :base()
        {
            AuthorizeHttpClient = new();
            AuthorizeHttpClient.BaseAddress = new Uri(ServerUrl.IdentityServer);
        }

        public Task<bool> AuthorizeUserRole(string role, string userName)
        {
            throw new NotImplementedException();
        }
    }
    // 여기서는 Employee가 Employer HR 의 소속되어 있는지를 확인해야됨.
    public class EmployeeWarehouserService : User
    {
        
    }
    public class EmployerWarehouserService : AuthorizationUser, IAuthorizeUser, IEmployeeWarehouser, IEmployerWarehouser, IPlatformWarehosuer
    {
        protected HttpClient WarehouserHttpClient;
        public EmployerWarehouserService()
        {
            WarehouserHttpClient = new HttpClient
            {
                BaseAddress = new Uri(ServerUrl.WarehouseServer)
            };
        }
        public async Task Test(Warehouse warehouse)
        {
            StringContent stringContent = new StringContent(JsonSerializer.Serialize(warehouse),
        Encoding.UTF8,
        Application.Json);

            await WarehouserHttpClient.PostAsync("/api", stringContent);
        }
        public async Task<HttpResponseMessage> CreateWarehouse()
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Id = "TestWarehouse";
            warehouse.Name = "TestWarehouse";

            StringContent stringContent = new StringContent(JsonSerializer.Serialize(warehouse),
        Encoding.UTF8,
        Application.Json);
            return await WarehouserHttpClient.PostAsync("/api/Warehouse", stringContent);
        }
        public virtual bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            WarehouserHttpClient = null;
        }
    }
    public interface IWarehouser 
    {
        
    }
    public interface IEmployeeWarehouser : IWarehouser
    {

    }
    public interface IEmployerWarehouser : IWarehouser
    {

    }
    public interface IPlatformWarehosuer : IWarehouser
    {

    }
    public interface IEmployeeWarehouseDTOService
    {
       
    }
}
