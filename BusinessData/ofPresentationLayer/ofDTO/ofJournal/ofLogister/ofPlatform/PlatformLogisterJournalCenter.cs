using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofLogister.ofPlatform
{
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterJournalCenter : LogisterJournalCenter
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterJCommodity : LogisterJCommodity
    {
    }
    [ActorContext(typeof(PlatformLogisterContext))]
    public class PlatformLogisterJournal : LogisterJournal
    {
    }
}
