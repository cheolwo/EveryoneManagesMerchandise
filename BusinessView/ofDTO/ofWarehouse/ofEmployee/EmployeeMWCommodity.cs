using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeMWCommodity : EmployeeMStatus
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string? EWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.LoadFrame)] public string? LoadFrame { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string? Warehouse { get; set; }
        [Detail][One(ViewNameofWarehouse.SWCommodity)] public string? SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity)] public string? WCommodity { get; set; }
    }
}
