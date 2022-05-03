using BusinessData;
using BusinessView.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    public class EmployerMWCommodity : EmployerMStatus
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string EWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.LoadFrame)] public string LoadFrame { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Detail][One(ViewNameofWarehouse.SWCommodity)] public string SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
    }
}
