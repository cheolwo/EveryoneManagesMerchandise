using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofOrder;
using BusinessData.ofOrder.ofModel;

namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(MOCommodity))]
    public class EmployerMOCommodity : EmployerMStatus
    {
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))] public string? OrderCenter { get; set; }
        [Detail][One(typeof(SOCommodity))] public string? SOCommodity { get; set; }
        [Detail][Many(typeof(List<EOCommodity>))]public string? EOCommodities { get; set; }
    }
}
