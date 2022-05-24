using AutoMapper;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
namespace BusinessView.ofTrade.ofEmployer
{
    [AutoMap(typeof(TradeCenter))]
    public class EmployerTradeCenter : EmployerCenter
    {
        [Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
    }
}
