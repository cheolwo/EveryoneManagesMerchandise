using AutoMapper;
using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(OrderCenter))]
    public class EmployeeOrderCenter : OrderCenterDTO
    {
       
    }
}
