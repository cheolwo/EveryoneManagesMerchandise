using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofWarehouse.ofEmployee
{
    public class EmployeeDividedTag : EmployeeEntity
    {
        [Get] public bool Attached { get; set; }
        [Get] public string IncomingTagId { get; set; }
        [Get] public string WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag)] public string IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
}
