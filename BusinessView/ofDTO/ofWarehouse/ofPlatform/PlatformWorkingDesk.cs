using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(WorkingDesk))]
    public class PlatformWorkingDesk : PlatformEntity
    {
        public bool IsUsed { get; set; }
    }
}
