using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    public class EmployerEOCommodity : EmployerEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        public string? MOCommodity { get; set; }
        public string? OCommodity { get; set; }
        public string? OrderCenter { get; set; }
    }
}
