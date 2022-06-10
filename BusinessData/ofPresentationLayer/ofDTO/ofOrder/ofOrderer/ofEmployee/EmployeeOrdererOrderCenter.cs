using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofOrderer.ofEmployee
{
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererOrderCenter : OrdererOrderCenter
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererOCommodity : OrdererOCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererSOCommodity : OrdererSOCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererMOCommodity : OrdererMOCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererEOCommodity : OrdererEOCommodity
    {
    }
}
