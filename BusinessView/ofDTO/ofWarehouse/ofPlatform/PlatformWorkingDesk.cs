using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    public class PlatformWorkingDesk : PlatformEntity
    {
        public bool IsUsed { get; set; }
        public string? Warehouse { get; set; }
    }
}
