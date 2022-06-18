using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderJournalCenter : JournalCenterDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderJCommodity : JCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderJournal : JournalDTO
    {
    }
}
