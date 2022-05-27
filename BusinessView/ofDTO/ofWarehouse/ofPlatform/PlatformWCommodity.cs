using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;
using BusinessView.ofExternal.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(WCommodity))]
    public class PlatformWCommodity : WCommodityDTO
    {
        
    }
}
