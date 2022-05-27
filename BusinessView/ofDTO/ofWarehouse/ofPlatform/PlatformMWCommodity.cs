using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(MWCommodity))]
    public class PlatformMWCommodity : MWCommodityDTO
    {
        
    }
}
