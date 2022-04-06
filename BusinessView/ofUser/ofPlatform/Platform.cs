using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofUser.ofPlatformer
{
    public class Platformer : User
    {
        private HttpClient HttpClient { get; set; }
		public Platformer()
		{
			HttpClient = new HttpClient();
			HttpClient.BaseAddress = new Uri(ServerUrl.IdentityServer);
		}
        public virtual Task<bool> LoginWithRoleCheck(string Id, string Roles)
        {
			throw new NotImplementedException();
        }
    }
    public class PlatformerForwarder : Platformer
    {
        private HttpClient HttpClient { get; set; }
        public PlatformerForwarder()
        {
            HttpClient= new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.TradeServer);
        }
    }
    public class PlatformerGroupOrderer : Platformer
    {
        private HttpClient HttpClient { get; set; }
        public PlatformerGroupOrderer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.GroupOrderServer);
        }
    }
    public class PlatformerMarketer : Platformer
    {
        private HttpClient HttpClient { get; set; }
        public PlatformerMarketer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.MarketServer);
        }
    }
    public class PlatformerOrderer : Platformer
    {
        private HttpClient HttpClient { get; set; }
        public PlatformerOrderer()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.OrderServer);
        }
    }
    public class PlatformerProducter : Platformer
    {
        private HttpClient HttpClient { get; set; }
        public PlatformerProducter()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.ProductServer);
        }
    }
    public class PlatformerWarehouser : Platformer
    {
        private HttpClient HttpClient { get; set; }
        public PlatformerWarehouser()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(ServerUrl.WarehouseServer);
        }
    }
}
