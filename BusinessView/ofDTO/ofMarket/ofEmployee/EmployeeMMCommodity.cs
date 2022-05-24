using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(MMCommodity))]
    public class EmployeeMMCommodity : EmployeeMStatus
    {
        [Detail][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.PMMCommodity, typeof(PMMCommodity))]public string? PMMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.SMCommodity, typeof(SMCommodity))]public string? SMCommodity {get; set;}
    }
}
