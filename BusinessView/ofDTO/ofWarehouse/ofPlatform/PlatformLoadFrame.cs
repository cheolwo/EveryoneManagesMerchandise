using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    public class PlatformLoadFrame : PlatformEntity
    {
        [Detail][Many(typeof(List<MWCommodity>))]public string? MWCommodities { get; set; }
        [Detail][One(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
