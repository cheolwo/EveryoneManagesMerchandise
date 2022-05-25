using AutoMapper;
using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(SOCommodity))]
    public class EmployeeSOCommodity : EmployeeSStatus
    {
        [Query][Get]public string? Price { get; set; }
        [Query][Get]public string? QualityTerms { get; set; }
        [Query][Get]public string? Incorterms { get; set; }
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
    }
}
