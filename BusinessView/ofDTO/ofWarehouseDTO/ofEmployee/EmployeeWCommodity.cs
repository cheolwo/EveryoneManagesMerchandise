using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofWarehouse.ofEmployee
{
    public class EmployeeWCommodity : EmployeeCommodity
    {
        [Get] public string Type { get; set; }
        [Get] public string PakcingBarcode { get; set; }
        [Detail] public double? Width { get; set; }
        [Detail] public double? height { get; set; }
        [Detail] public double? length { get; set; }
        [Get] public int Quantity { get; set; }
        [Get] public string MCommodityId { get; set; }
        [Get] public string TCommodityId { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public string SWCommodities { get; set; }  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string EWCommodities { get; set; }  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string MWCommodities { get; set; }  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
}
