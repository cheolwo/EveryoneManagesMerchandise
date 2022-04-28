using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofWarehouse.ofEmployer
{
    public class EmployerWorkingDesk : EmployerEntity
    {
        public bool IsUsed { get; set; }
        public string Warehouse { get; set; }
    }
}
