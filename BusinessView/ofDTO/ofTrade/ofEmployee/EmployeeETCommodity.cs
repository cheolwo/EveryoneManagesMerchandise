using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeETCommodity : EmployeeEStatus
    {
        [Get]public string? MTCommodityId {get; set;}
        [Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
