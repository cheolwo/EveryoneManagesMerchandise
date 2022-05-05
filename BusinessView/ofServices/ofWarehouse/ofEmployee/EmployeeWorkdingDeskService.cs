using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeWorkingDeskService : WarehouseService
    {
        public EmployeeWorkingDeskService(WarehouseServiceOptions options)
            : base(options)
        {

        }

    }
}
