using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    public class EmployeeEOCommodity : EmployeeEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        public string? MOCommodity { get; set; }
        public string? OCommodity { get; set; }
        public string? OrderCenter { get; set; }
    }
}
