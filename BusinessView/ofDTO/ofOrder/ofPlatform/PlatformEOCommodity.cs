using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    public class PlatformEOCommodity : PlatformEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        public string? MOCommodity { get; set; }
        public string? OCommodity { get; set; }
        public string? OrderCenter { get; set; }
    }
}
