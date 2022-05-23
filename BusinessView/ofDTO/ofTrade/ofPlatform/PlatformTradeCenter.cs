using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformTradeCenter : PlatformCenter
    {
        [Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
    }
}
