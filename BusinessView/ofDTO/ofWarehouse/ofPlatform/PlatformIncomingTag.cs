using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(IncomingTag))]
    public class PlatformIncomingTag : PlatformEntity
    {
        [Query][Get] public string? SWCommodityId { get; set; }
        [Query][Get] public string? WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
    }
}
