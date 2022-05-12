using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    public class PlatformIncomingTag : PlatformEntity
    {
        [Get] public string? SWCommodityId { get; set; }
        [Get] public string? WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string? Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag)] public string? DividedTags { get; set; }
    }
}
