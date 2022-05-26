using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(EWCommodity))]
    public class EmployerEWCommodity : EmployerEStatus
    {
        [Query][Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity, typeof(MWCommodity))] public string? MWCommodity { get; set; }
    }
}
