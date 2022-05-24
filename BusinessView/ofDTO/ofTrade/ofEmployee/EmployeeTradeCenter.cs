using AutoMapper;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;

namespace BusinessView.ofTrade.ofEmployee
{
    [AutoMap(typeof(TradeCenter))]
    public class EmployeeTradeCenter : EmployeeCenter
    {
        [Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
    }
}
