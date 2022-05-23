using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofEmployer
{
    public class EmployerTCommodity : EmployerCommodity
    {
        [Get]public string? PCommodityId {get; set;}
        [Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
        [Detail][One(typeof(TradeCenter))]public string? TradeCenter {get; set;}
    }
}
