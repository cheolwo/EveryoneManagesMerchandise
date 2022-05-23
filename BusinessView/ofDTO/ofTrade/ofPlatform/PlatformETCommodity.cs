using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformETCommodity : PlatformEStatus
    {
        [Get]public string? MTCommodityId {get; set;}
        [Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
