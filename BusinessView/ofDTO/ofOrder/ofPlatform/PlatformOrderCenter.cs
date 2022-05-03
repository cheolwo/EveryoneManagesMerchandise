using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    public class PlatformOrderCenter : PlatformCenter
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity)] public string OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public string SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public string EOCommodities { get; set; }
    }
}
