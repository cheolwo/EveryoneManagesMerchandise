using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;
using BusinessView.ofGeneric;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    public class PlatformDividedTag : PlatformEntity
    {
        [Get] public bool Attached { get; set; }
        [Get] public string? IncomingTagId { get; set; }
        [Get] public string? WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag, typeof(IncomingTag))] public string? IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
