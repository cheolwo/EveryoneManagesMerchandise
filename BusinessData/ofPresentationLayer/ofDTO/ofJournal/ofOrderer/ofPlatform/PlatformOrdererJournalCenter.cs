using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;


namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofOrderer.ofPlatform
{
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererJournalCenter : OrdererJournalCenter
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererJCommodity : OrdererJCommodity
    {
    }
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrdererJournal : OrdererJournal
    {
    }
}
