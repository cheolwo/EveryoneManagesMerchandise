using BusinessData;
using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeSWCommodity : EmployeeSStatus
    {
        [Get] public int IncomingQuantity { get; set; }
        [Get] public string IncomingTagId { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string MWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
}
