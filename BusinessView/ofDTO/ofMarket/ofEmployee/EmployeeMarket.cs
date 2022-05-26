using AutoMapper;
using BusinessData.ofMarket;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(Market))]
    public class EmployeeMarket : EmployeeCenter
    {
        [Query][Get]public string NameofMarket { get; set; }
        [Many(ViewNameofMarket.PlatMarket, typeof(List<PlatMarket>))]public string? PlatMarkets { get; set; }
        [Many(ViewNameofMarket.MCommodity, typeof(List<MCommodity>))]public string? MCommodities {get; set;}
        [Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string? SMCommodities {get; set; }
        [Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
    }
}
