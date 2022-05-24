using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(MCommodity))]
    public class EmployerMCommodity : EmployerCommodity
    {
        [One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [One(ViewNameofMarket.DetailofMCommodity, typeof(DetailofMCommodity))]public string? DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        [One(ViewNameofMarket.Option, typeof(Option))]public string? Options { get; set; }
        [Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string? SMCommodities {get; set;}
        [Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
    }
}
