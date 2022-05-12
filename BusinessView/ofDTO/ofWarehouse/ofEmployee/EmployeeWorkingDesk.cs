using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeWorkingDesk : EmployeeEntity
    {
        public bool IsUsed { get; set; }
        public string? Warehouse { get; set; }
    }
}
