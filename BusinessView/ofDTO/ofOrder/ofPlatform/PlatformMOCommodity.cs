using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    public class PlatformMOCommodity : PlatformMStatus
    {
        [Detail] public string? OCommodity { get; set; }
        [Detail] public string? OrderCenter { get; set; }
        [Detail] public string? SOCommodity { get; set; }
        public string? EOCommodities { get; set; }
    }
}
