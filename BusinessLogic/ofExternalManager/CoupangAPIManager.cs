using BusinessLogic.ofExternalManager.ofBody;
using System.Net.Http;

namespace BusinessLogic.ofExternalManager
{
    public class CoupangAPIManager
    {
        private HttpClient HttpClient { get; set; }
        public CoupangAPIManager()
        {
            HttpClient = new HttpClient();
        }
        public void CreateWarehouse(string vendorId, CoupangWarehouseBody body)
        {
            string RequestPath = $"https://api-gateway.coupang.com/v2/providers/openapi/apis/api/v4/vendors/A00012345/outboundShippingCenters";
        }
    }
}
