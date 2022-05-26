using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofMarket;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(SMCommodity))]
    public class PlatformSMCommodity : PlatformSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity,typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity,typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Query][Get]public string? SWCommodityId {get; set;}
    }
}
