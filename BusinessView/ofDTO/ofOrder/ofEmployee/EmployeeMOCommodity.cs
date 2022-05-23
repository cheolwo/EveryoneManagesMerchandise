using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    public class EmployeeMOCommodity : EmployeeMStatus
    {
        [Detail] public string? OCommodity { get; set; }
        [Detail] public string? OrderCenter { get; set; }
        [Detail] public string? SOCommodity { get; set; }
        public string? EOCommodities { get; set; }
    }
}
