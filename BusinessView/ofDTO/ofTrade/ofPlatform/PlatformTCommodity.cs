using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformTCommodity : PlatformCommodity
    {
        public string? PCommodityId {get; set;}
        public string? STCommodities {get; set;}
        public string? MTCommodities {get; set;}
        public string? ETCommodities {get; set;}
        public string? TradeCenter {get; set;}
    }
}
