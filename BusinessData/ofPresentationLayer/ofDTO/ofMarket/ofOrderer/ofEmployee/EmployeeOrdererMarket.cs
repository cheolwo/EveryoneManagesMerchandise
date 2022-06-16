using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofOrderer.ofEmployee
{
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererMarket : OrdererMarket
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererPlatMarket : OrdererPlatMarket
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererMCommodity : OrdererMCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererSMCommodity : OrdererSMCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererMMCommodity : OrdererMMCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererEMCommodity : OrdererEMCommodity
    {
    }
}
