using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofOrder.ofEmployee
{
    public class EmployeeEOCommodity : EmployeeEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        public string MOCommodity { get; set; }
        public string OCommodity { get; set; }
        public string OrderCenter { get; set; }
    }
}
