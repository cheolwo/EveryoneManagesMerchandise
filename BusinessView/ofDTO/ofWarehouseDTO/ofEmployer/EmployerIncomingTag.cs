using BusinessData;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofWarehouse.ofEmployer
{
    public class EmployerIncomingTag : EmployerEntity
    {
        [Get] public string SWCommodityId { get; set; }
        [Get] public string WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag)] public string DividedTags { get; set; }
    }
}
