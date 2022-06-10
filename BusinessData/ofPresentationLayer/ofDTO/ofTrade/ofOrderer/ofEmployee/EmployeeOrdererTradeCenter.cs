using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofOrderer.ofEmployee
{
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererTradeCenter : OrdererTradeCenter
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererTCommodity : OrdererTCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererSTCommodity : OrdererSTCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererMTCommodity : OrdererMTCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererETCommodity : OrdererETCommodity
    {
    }
}
