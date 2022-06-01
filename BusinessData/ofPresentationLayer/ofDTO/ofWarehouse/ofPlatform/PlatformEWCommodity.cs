using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(EWCommodity))]
    public class PlatformEWCommodity : EWCommodityDTO
    {
       
    }
}
