using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofGroupOrder;
namespace BusinessView.ofDTO.ofGroupOrder.ofEmployer
{
    public class EmployerGOC : EmployerCenter
    {
        public string? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
    }
}
