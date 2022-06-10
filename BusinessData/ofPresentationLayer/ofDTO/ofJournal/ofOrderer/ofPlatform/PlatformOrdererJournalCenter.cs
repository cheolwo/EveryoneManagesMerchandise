using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
