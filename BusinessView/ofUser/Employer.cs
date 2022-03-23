using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofUser
{
    public class Employer
	{
		private HttpClient HttpClient { get; set; }
		protected bool IsInRole { get; set; }
		public Employer()
		{
			HttpClient = new HttpClient();
			IsInRole = false;
			HttpClient.BaseAddress = new Uri("https://identityserverpl.azurewebsites.net");
		}
        public virtual Task<bool> LoginWithRoleCheck(string Id, string Roles)
        {
			string Role = nameof(Employer);
			throw new NotImplementedException();
        }
    }
}
