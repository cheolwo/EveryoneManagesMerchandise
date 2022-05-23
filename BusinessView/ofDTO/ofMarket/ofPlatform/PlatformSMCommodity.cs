using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofPlatform
{
    public class PlatformSMCommodity : PlatformSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity)]public string? MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string? Market {get; set;}
        public string? SWCommodityId {get; set;}
    }
}
