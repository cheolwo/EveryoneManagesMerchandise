using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformEPCommodityService : ProductService
    {
        public PlatformEPCommodityService(ProductServiceOptions options)
            : base(options)
        {

        }

    }
}
