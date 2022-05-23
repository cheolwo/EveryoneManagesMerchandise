using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeEWCommodity : EmployeeEStatus
    {
        [Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity, typeof(MWCommodity))] public string? MWCommodity { get; set; }
    }
}
