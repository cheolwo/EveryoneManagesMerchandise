using BusinessData.ofWarehouse.Model;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofUser
{
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
    
    public class Warehouser : AuthenticateUser, IAuthorizeUser, IEmployeeWarehouser, IEmployerWarehouser, IPlatformWarehosuer
    {
        protected HttpClient WarehouserHttpClient;
        public Warehouser()
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
}
