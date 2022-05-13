using BusinessData;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofWarehouse.ofPlatform
{
    public class PlatformDividedTag : PlatformEntity
    {
        [Get] public bool Attached { get; set; }
        [Get] public string IncomingTagId { get; set; }
        [Get] public string WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag)] public string IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
}
