using AutoMapper;
using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(OrderCenter))]
    public class PlatformOrderCenter : OrderCenterDTO
    {
       
    }
}
