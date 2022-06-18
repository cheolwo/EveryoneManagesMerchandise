using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterJournalCenter : JournalCenterDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterJCommodity : JCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterJournal : JournalDTO
    {
    }
}
