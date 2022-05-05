using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeLoadFrameService : WarehouseService
    {
        public EmployeeLoadFrameService(WarehouseServiceOptions options)
            : base(options)
        {

        }
    }
}
