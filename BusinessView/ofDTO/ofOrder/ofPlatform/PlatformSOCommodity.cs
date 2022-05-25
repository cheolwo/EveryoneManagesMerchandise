using AutoMapper;
using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(SOCommodity))]
    public class PlatformSOCommodity : PlatformSStatus
    {
        [Query][Get]public string? Price { get; set; }
        [Query][Get]public string? QualityTerms { get; set; }
        [Query][Get]public string? Incorterms { get; set; }
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
    }
    
}
