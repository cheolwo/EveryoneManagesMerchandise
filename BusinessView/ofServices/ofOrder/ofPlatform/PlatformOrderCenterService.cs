using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformOrderCenterService : OrderService
    {
        public PlatformOrderCenterService(OrderServiceOptions options)
            : base(options)
        {

        }

       
    }
}
