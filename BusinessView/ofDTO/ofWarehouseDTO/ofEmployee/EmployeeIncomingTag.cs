using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofWarehouse.ofEmployee
{
    public class EmployeeIncomingTag : EmployeeEntity
    {
        [Get] public string SWCommodityId { get; set; }
        [Get] public string WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag)] public string DividedTags { get; set; }
    }
}
