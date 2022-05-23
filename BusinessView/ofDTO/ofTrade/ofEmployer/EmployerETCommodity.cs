using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofTrade.ofEmployer
{
    public class EmployerETCommodity : EmployerEStatus
    {
        [Get]public string? MTCommodityId {get; set;}
        [Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
