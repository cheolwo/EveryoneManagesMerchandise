using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofForwarder.ofEmployee
{
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderTradeCenter : ForwarderTradeCenter
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderTCommodity : ForwarderTCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderSTCommodity : ForwarderSTCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderMTCommodity : ForwarderMTCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderETCommodity : ForwarderETCommodity
    {
    }
}
