using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofOrder;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(EOCommodity))]
    public class EmployerEOCommodity : EmployerEStatus
    {
        [Query][Get] public int OutgoingQuantity { get; set; } // 출고수량
        [One(typeof(MOCommodity))] public string? MOCommodity { get; set; }
        [One(typeof(OCommodity))] public string? OCommodity { get; set; }
    }
}
