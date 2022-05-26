using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofMarket;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(SMCommodity))]
    public class EmployerSMCommodity : EmployerSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Query][Get]public string? SWCommodityId {get; set;}
    }
}
