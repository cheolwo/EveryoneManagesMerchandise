using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformTCommodity : PlatformCommodity
    {
        [Get]public string? PCommodityId {get; set;}
        [Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
        [Detail][One(typeof(TradeCenter))]public string? TradeCenter {get; set;}
    }
}
