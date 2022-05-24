using AutoMapper;
using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(OrderCenter))]
    public class EmployerOrderCenter : EmployerCenter
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity, typeof(List<OCommodity>))] public string? OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string? SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string? EOCommodities { get; set; }
    }
}
