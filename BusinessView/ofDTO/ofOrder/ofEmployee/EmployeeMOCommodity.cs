using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofOrder;
using BusinessData.ofOrder.ofModel;

namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(MOCommodity))]
    public class EmployeeMOCommodity : EmployeeMStatus
    {
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))] public string? OrderCenter { get; set; }
        [Detail][One(typeof(SOCommodity))] public string? SOCommodity { get; set; }
        [Detail][Many(typeof(List<EOCommodity>))]public string? EOCommodities { get; set; }
    }
}
