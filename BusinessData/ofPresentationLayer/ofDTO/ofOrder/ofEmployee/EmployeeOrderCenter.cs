using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(OrderCenter))]
    [HttpDTOService(typeof(EmployeeOrderCenterService))]
    public class EmployeeOrderCenter : OrderCenterDTO
    {
       
    }
}
