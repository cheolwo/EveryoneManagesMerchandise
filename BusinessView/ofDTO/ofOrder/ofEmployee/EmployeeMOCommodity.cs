using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    public class EmployeeMOCommodity : EmployeeMStatus
    {
        [Detail] public string OCommodity { get; set; }
        [Detail] public string OrderCenter { get; set; }
        [Detail] public string SOCommodity { get; set; }
        public string EOCommodities { get; set; }
    }
}
