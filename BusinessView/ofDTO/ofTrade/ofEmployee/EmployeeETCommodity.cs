using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofTrade.ofEmployee
{
    [AutoMap(typeof(ETCommodity))]
    public class EmployeeETCommodity : EmployeeEStatus
    {
        [Query][Get]public string? MTCommodityId {get; set;}
        [Query][Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
