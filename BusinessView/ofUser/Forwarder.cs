namespace BusinessView.ofUser
{
    public class Forwarder : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }

        public Task<bool> AuthorizeUserRole(string role, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
