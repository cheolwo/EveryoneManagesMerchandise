using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerWorkingDeskService : WarehouseService
    {
        public EmployerWorkingDeskService(WarehouseServiceOptions options)
            : base(options)
        {

        }
    }
}
