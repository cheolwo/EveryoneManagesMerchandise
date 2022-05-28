using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(WorkingDesk))]
    public class PlatformWorkingDesk : WorkingDeskDTO
    {
       
    }
}
