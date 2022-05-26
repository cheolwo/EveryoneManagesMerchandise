using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofOrder;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(EOCommodity))]
    public class EmployeeEOCommodity : EmployeeEStatus
    {
        [Query][Get] public int OutgoingQuantity { get; set; } // 출고수량
        [One(typeof(MOCommodity))]public string? MOCommodity { get; set; }
        [One(typeof(OCommodity))]public string? OCommodity { get; set; }
        [One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
    }
}
