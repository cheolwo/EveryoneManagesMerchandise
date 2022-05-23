using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    public class EmployerWCommodity : EmployerCommodity
    {
        [Get] public string? Type { get; set; }
        [Get] public string? PakcingBarcode { get; set; }
        [Detail] public double? Width { get; set; }
        [Detail] public double? height { get; set; }
        [Detail] public double? length { get; set; }
        [Get] public int Quantity { get; set; }
        [Get] public string? MCommodityId { get; set; }
        [Get] public string? TCommodityId { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
