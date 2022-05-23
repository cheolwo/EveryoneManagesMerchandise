using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeDividedTag : EmployeeEntity
    {
        [Get] public bool Attached { get; set; }
        [Get] public string? IncomingTagId { get; set; }
        [Get] public string? WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag, typeof(IncomingTag))] public string? IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
