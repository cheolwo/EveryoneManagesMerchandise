using BusinessData;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofWarehouse.ofPlatform
{
    public class PlatformEWCommodity : PlatformEStatus
    {
        [Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity)] public string MWCommodity { get; set; }
    }
}
