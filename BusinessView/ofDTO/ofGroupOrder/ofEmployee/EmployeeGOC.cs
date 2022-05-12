using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofGroupOrder.ofEmployee
{
    public class EmployeeGOC : EmployeeCenter
    {
        public List<string>? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
    }
}
