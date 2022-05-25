using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(WCommodity))]
    public class EmployerWCommodity : EmployerCommodity
    {
        [Query][Get] public string? Type { get; set; }
        [Query][Get] public string? PakcingBarcode { get; set; }
        [Query][Detail] public double? Width { get; set; }
        [Query][Detail] public double? height { get; set; }
        [Query][Detail] public double? length { get; set; }
        [Query][Get] public int Quantity { get; set; }
        [Query][Get] public string? MCommodityId { get; set; }
        [Query][Get] public string? TCommodityId { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
