namespace BusinessView.ofUser
{
    public class Seller : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }

        public bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }
    }
}
