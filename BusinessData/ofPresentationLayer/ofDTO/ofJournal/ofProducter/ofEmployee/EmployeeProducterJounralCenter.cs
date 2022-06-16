using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofProducter.ofEmployee
{
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterJournalCenter : ProducterJournalCenter
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterJCommodity : ProducterJCommodity
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterJournal : ProducterJournal
    {
    }
}
