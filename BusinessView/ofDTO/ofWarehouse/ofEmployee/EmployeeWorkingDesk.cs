using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeWorkingDesk : EmployeeEntity
    {
        [Get]public bool IsUsed { get; set; }
        [Detail][One(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
