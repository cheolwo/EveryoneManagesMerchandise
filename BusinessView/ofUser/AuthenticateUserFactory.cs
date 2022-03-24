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
    
    // 계정관리서버로 데이터를 전달한다.
    public class AuthenticateUser
    {
        public HttpClient HttpClient { get; set; }
        public AuthenticateUser()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://identityserverinplanlogistcs.azurewebsites.net/");
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
        bool CheckRoles(string IdentityUserId);
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
                        AuthorizeUsers.Add(new Warehouser());
                        break;
                    case SystemRole.Role_Orderer:
                        AuthorizeUsers.Add(new Orderer());
                        break;
                    case SystemRole.Role_Seller:
                        AuthorizeUsers.Add(new Seller());
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
