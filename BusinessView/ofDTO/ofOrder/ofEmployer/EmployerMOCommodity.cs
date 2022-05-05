using BusinessData;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    public class EmployerMOCommodity : EmployerMStatus
    {
        [Detail] public string? OCommodity { get; set; }
        [Detail] public string? OrderCenter { get; set; }
        [Detail] public string? SOCommodity { get; set; }
        public string? EOCommodities { get; set; }
    }
}
