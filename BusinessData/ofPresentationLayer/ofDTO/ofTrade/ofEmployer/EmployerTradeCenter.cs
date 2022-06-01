using AutoMapper;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofTrade;
namespace BusinessView.ofTrade.ofEmployer
{
    [AutoMap(typeof(TradeCenter))]
    public class EmployerTradeCenter : TradeCenterDTO
    {
        
    }
}
