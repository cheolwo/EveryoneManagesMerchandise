using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofEmployer
{
    public class EmployerTradeCenter : EmployerCenter
    {
        [Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
    }
}
