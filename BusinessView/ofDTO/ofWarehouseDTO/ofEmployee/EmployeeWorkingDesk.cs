using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofWarehouse.ofEmployee
{
    public class EmployeeWorkingDesk : EmployeeEntity
    {
        public bool IsUsed { get; set; }
        public string Warehouse { get; set; }
    }
}
