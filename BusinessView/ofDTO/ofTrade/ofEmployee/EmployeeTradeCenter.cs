using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeTradeCenter : EmployeeCenter
    {
        [Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
    }
}
