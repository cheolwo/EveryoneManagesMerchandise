using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofUser
{
    public static class SystemRole
    {
        public const string Role_Warehouser = "Warehouser";
        public const string Role_Orderer = "Orderer";
        public const string Role_Producter = "Producter";
        public const string Role_Forwarder = "Forwarder";
        public const string Role_Seller = "Seller";
    }
    public static class ServerUrl
    {
        public const string OrderServer = "https://ordercontractserver.azurewebsites.net";
        public const string GroupOrderServer = "https://groupordercontractserver.azurewebsites.net";
        public const string ProductServer = "https://productionserver.azurewebsites.net";
        public const string TradeServer = "https://tradeserver.azurewebsites.net"; 
        public const string WarehouseServer = "https://warehouseserver.azurewebsites.net";
        public const string MarketServer = "";
        public const string HRServer = "https://hrserver.azurewebsites.net";
        public const string JournalServer = "https://journalserver.azurewebsites.net";
        public const string IdentityServer = "https://identityserverpl.azurewebsites.net";
        // TradeServer의 경우 ContractServer로 생각을 바꿔야 되지 않을까... 생각이 드네.
    }
    
    // 계정관리서버로 데이터를 전달한다.
    public interface IAuthenticateUser
    {

    }
    public class User : IAuthenticateUser
    {
        protected HttpClient IdentityHttpClient { get; set; }
        public User()
        {
            IdentityHttpClient = new HttpClient();
            IdentityHttpClient.BaseAddress = new Uri(ServerUrl.IdentityServer);       
        }
        public async Task Login(string id, string password)
        {
            
        }
//        public async Task<IEnumerable<WeatherForecast>> WeatherforecastGet()
////        {
////            var httpResponseMessage = await HttpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("weatherforecast");
////            return httpResponseMessage;
////        }
//        public async Task CreateItemAsync(TodoItem todoItem)
//        {
//            var todoItemJson = new StringContent(
//                JsonSerializer.Serialize(todoItem),
//                Encoding.UTF8,
//                Application.Json); // using static System.Net.Mime.MediaTypeNames;

//            using var httpResponseMessage =
//                await _httpClient.PostAsync("/api/TodoItems", todoItemJson);

//            httpResponseMessage.EnsureSuccessStatusCode();
//        }
//        public async Task SaveItemAsync(TodoItem todoItem)
//        {
//            var todoItemJson = new StringContent(
//                JsonSerializer.Serialize(todoItem),
//                Encoding.UTF8,
//                Application.Json);

//            using var httpResponseMessage =
//                await _httpClient.PutAsync($"/api/TodoItems/{todoItem.Id}", todoItemJson);

//            httpResponseMessage.EnsureSuccessStatusCode();
//        }
//        public async Task DeleteItemAsync(long itemId)
//        {
//            using var httpResponseMessage =
//                await _httpClient.DeleteAsync($"/api/TodoItems/{itemId}");

//            httpResponseMessage.EnsureSuccessStatusCode();
//        }

    }
    public interface IAuthorizeUser
    {
        Task<bool> AuthorizeUserRole(string role, string userName);
    }

    public class AuthorizeUserFactory
    {
        private List<IAuthorizeUser> AuthorizeUsers = new();
        public void Clear()
        {
            AuthorizeUsers.Clear();
        }
        public List<IAuthorizeUser> CreateAuthenticateUser(IList<string> Roles)
        {
            foreach (var Role in Roles)
            {
                switch (Role)
                {
                    case SystemRole.Role_Warehouser:
                        //AuthorizeUsers.Add(new EmployerWarehouse());
                        break;
                    case SystemRole.Role_Orderer:
                        AuthorizeUsers.Add(new Orderer());
                        break;
                    case SystemRole.Role_Seller:
                        AuthorizeUsers.Add(new Marketer());
                        break;
                    case SystemRole.Role_Producter:
                        AuthorizeUsers.Add(new Producter());
                        break;
                    case SystemRole.Role_Forwarder:
                        AuthorizeUsers.Add(new Forwarder());
                        break;
                    default:
                        break;
                }
            }
                return AuthorizeUsers;
        }
    }
}
