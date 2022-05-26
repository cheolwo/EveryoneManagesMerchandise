using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofTrade.ofEmployer
{
    [AutoMap(typeof(ETCommodity))]
    public class EmployerETCommodity : EmployerEStatus
    {
        [Query][Get]public string? MTCommodityId {get; set;}
        [Query][Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
