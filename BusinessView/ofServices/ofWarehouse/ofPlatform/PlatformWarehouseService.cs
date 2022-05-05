using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformWarehouseService : WarehouseService
    {
        public PlatformWarehouseService(WarehouseServiceOptions options)
            : base(options)
        {

        }
    }
}
