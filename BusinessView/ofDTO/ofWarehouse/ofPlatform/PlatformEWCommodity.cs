using BusinessData;
using BusinessView.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    public class PlatformEWCommodity : PlatformEStatus
    {
        [Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity)] public string MWCommodity { get; set; }
    }
}
