using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofMarket.ofPlatform
{
    public class PlatformSMCommodity : PlatformSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public MCommodity MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity)]public string MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public Market Market {get; set;}
        public string SWCommodityId {get; set;}
    }
}
