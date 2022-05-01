using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofGroupOrder.ofEmployer
{
    public class EmployerGOC : EmployerCenter
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
}
