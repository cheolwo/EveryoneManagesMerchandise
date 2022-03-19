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
    
    public class AuthenticateUser
    {
        public HttpClient HttpClient { get; set; }
    }
    public interface IAuthorizeUser
    {

    }
    public class Warehouser : IAuthorizeUser
{
        public HttpClient HttpClient { get; set; }
    }
    public class Forwarder : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }
    }
    public class Orderer : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }
    }
    public class Seller : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }
    }
    public class Producter : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }
    }

    public class AuthorizeUserFactory
    {
        private List<IAuthorizeUser> AuthorizeUsers = new();
        public AuthorizeUserFactory()
        {

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
