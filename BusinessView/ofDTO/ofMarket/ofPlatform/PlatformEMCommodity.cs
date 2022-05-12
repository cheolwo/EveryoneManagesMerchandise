using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofMarket.ofPlatform
{
    public class PlatformEMCommodity : PlatformEStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public string? MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity)]public string? MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket)]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string? Market {get; set;}
    }
}
