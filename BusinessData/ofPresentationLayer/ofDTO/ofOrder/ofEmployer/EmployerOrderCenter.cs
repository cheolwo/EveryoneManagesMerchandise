using AutoMapper;
using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(OrderCenter))]
    public class EmployerOrderCenter : OrderCenterDTO
    {
       
    }
}
