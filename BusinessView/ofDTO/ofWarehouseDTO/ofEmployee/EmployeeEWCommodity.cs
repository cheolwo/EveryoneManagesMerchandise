using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofWarehouse.ofEmployee
{
    public class EmployeeEWCommodity : EmployeeEStatus
    {
        [Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity)] public string MWCommodity { get; set; }
    }
}
