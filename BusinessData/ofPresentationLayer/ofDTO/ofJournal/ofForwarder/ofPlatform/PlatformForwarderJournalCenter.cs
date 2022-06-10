using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofForwarder.ofPlatform
{
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderJournalCenter : ForwarderJournalCenter
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderJCommodity : ForwarderJCommodity
    {
    }
    [ActorContext(typeof(PlatformForwarderContext))]
    public class PlatformForwarderJournal : ForwarderJournal
    {
    }
}
