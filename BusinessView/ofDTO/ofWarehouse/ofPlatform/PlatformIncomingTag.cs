using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(IncomingTag))]
    public class PlatformIncomingTag : IncomingTagDTO
    {
        
    }
}
