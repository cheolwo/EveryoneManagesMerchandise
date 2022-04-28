using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofGroupOrder.ofEmployee
{
    public class EmployeeGOC : EmployeeCenter
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
}
