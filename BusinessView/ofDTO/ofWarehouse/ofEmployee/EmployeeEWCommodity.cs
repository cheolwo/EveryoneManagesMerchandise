using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeEWCommodity : EmployeeEStatus
    {
        [Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity)] public string? WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string? Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity)] public string? MWCommodity { get; set; }
    }
}
