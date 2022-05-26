using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;
using BusinessView.ofGeneric;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(DividedTag))]
    public class PlatformDividedTag : PlatformEntity
    {
        [Query][Get] public bool Attached { get; set; }
        [Query][Get] public string? IncomingTagId { get; set; }
        [Query][Get] public string? WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag, typeof(IncomingTag))] public string? IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
