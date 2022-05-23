using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    public class EmployerMWCommodity : EmployerMStatus
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.LoadFrame, typeof(LoadFrame))] public string? LoadFrame { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Detail][One(ViewNameofWarehouse.SWCommodity, typeof(SWCommodity))] public string? SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
    }
}
