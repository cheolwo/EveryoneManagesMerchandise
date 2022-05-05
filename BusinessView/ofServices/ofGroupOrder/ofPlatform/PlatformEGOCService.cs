using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformEGOCService : GroupOrderService
    {
        public PlatformEGOCService(GroupOrderServiceOptions options)
            : base(options)
        {

        }

     
    }
}
