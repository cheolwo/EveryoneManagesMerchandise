namespace BusinessView.ofUser
{
    public class Forwarder : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }

        public bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }
    }
}
