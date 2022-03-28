namespace BusinessView.ofUser
{
    public class Producter : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }

        public bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }
    }
}
