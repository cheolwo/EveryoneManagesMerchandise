using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofTrade.ofEmployee
{
    [AutoMap(typeof(TCommodity))]
    public class EmployeeTCommodity : EmployeeCommodity
    {
        [Query][Get]public string? PCommodityId {get; set;}
        [Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
        [Detail][One(typeof(TradeCenter))]public string? TradeCenter {get; set;}
    }
}
