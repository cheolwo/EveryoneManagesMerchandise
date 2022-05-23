using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeETCommodity : EmployeeEStatus
    {
        [Get]public string? MTCommodityId {get; set;}
        [Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
