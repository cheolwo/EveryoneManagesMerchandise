using AutoMapper;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofTrade;
namespace BusinessView.ofTrade.ofEmployee
{
    [AutoMap(typeof(TradeCenter))]
    public class EmployeeTradeCenter : TradeCenterDTO
    {
        
    }
}
