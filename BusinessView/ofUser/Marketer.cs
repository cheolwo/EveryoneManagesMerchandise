﻿namespace BusinessView.ofUser
{
    public class Marketer : IAuthorizeUser
    {
        public HttpClient HttpClient { get; set; }

        public Task<bool> AuthorizeUserRole(string role, string userName)
        {
            throw new NotImplementedException();
        }

        public bool CheckRoles(string IdentityUserId)
        {
            throw new NotImplementedException();
        }
    }
}