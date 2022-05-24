using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(EMCommodity))]
    public class EmployerEMCommodity : EmployerEStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity, typeof(MMCommodity))]public string? MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
    }
}
