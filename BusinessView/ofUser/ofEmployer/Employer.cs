using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofUser
{
    public class Employer : User
	{
		private HttpClient HttpClient { get; set; }
		public Employer()
		{
			HttpClient = new HttpClient();
			HttpClient.BaseAddress = new Uri(ServerUrl.IdentityServer);
		}
        public virtual Task<bool> LoginWithRoleCheck(string Id, string Roles)
        {
			throw new NotImplementedException();
        }
    }
    public class EmployerForwarder : Employer
    {
        private HttpClient HttpClient { get; set; }
        public EmployerForwarder()
        {
            HttpClient= new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.TradeServer);
        }
    }
    public class EmployerGroupOrderer : Employer
    {
        private HttpClient HttpClient { get; set; }
        public EmployerGroupOrderer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.GroupOrderServer);
        }
    }
    public class EmployerMarketer : Employer
    {
        private HttpClient HttpClient { get; set; }
        public EmployerMarketer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.MarketServer);
        }
    }
    public class EmployerOrderer : Employer
    {
        private HttpClient HttpClient { get; set; }
        public EmployerOrderer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.OrderServer);
        }
    }
    public class EmployerProducter : Employer
    {
        private HttpClient HttpClient { get; set; }
        public EmployerProducter()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.ProductServer);
        }
    }
    public class EmployerWarehouser : Employer
    {
        private HttpClient HttpClient { get; set; }
        public EmployerWarehouser()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.WarehouseServer);
        }
    }
}
