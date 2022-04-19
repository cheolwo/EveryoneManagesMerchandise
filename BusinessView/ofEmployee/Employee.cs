using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofUser.ofEmployee
{
    public class Employee : User
    {
        private HttpClient HttpClient { get; set; }
		public Employee()
		{
			HttpClient = new HttpClient();
			HttpClient.BaseAddress = new Uri(ServerUrl.IdentityServer);
		}
        public virtual Task<bool> LoginWithRoleCheck(string Id, string Roles)
        {
			throw new NotImplementedException();
        }
    }
    public class EmployeeForwarder : Employee
    {
        private HttpClient HttpClient { get; set; }
        public EmployeeForwarder()
        {
            HttpClient= new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.TradeServer);
        }
    }
    public class EmployeeGroupOrderer : Employee
    {
        private HttpClient HttpClient { get; set; }
        public EmployeeGroupOrderer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.GroupOrderServer);
        }
    }
    public class EmployeeMarketer : Employee
    {
        private HttpClient HttpClient { get; set; }
        public EmployeeMarketer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.MarketServer);
        }
    }
    public class EmployeeOrderer : Employee
    {
        private HttpClient HttpClient { get; set; }
        public EmployeeOrderer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.OrderServer);
        }
    }
    public class EmployeeProducter : Employee
    {
        private HttpClient HttpClient { get; set; }
        public EmployeeProducter()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.ProductServer);
        }
    }
    public class EmployeeWarehouser : Employee
    {
        private HttpClient HttpClient { get; set; }
        public EmployeeWarehouser()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.WarehouseServer);
        }
    }
}
