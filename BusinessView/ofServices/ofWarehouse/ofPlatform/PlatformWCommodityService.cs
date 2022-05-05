using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformWCommodityService : WarehouseService
    {
        public PlatformWCommodityService(WarehouseServiceOptions options)
            : base(options)
        {

        }
    }
}
