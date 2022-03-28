namespace BusinessView.ofUser
{
    public class Orderer : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }

        public bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }
    }
}
