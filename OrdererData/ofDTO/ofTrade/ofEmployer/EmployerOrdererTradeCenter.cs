using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofEmployer;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofOrderer.ofEmployer
{
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererTradeCenter : OrdererTradeCenter
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererTCommodity : OrdererTCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererSTCommodity : OrdererSTCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererMTCommodity : OrdererMTCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererETCommodity : OrdererETCommodity
    {
    }
}
