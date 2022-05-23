using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeMWCommodity : EmployeeMStatus
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.LoadFrame, typeof(LoadFrame))] public string? LoadFrame { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Detail][One(ViewNameofWarehouse.SWCommodity, typeof(SWCommodity))] public string? SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
    }
}
