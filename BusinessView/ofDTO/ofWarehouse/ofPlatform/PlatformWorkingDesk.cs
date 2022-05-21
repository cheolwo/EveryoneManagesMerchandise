using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    public class PlatformWorkingDesk : PlatformEntity
    {
        [Get]public bool IsUsed { get; set; }
        [Detail][One(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
