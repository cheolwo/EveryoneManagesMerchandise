using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(IncomingTag))]
    public class EmployerIncomingTag : EmployerEntity
    {
        [Query][Get] public string? SWCommodityId { get; set; }
        [Query][Get] public string? WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
    }
}
