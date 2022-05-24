using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(EMCommodity))]
    public class PlatformEMCommodity : PlatformEStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity, typeof(MMCommodity))]public string? MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
    }
}
