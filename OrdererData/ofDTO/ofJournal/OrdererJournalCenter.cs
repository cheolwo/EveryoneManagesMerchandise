using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererJournalCenter : JournalCenterDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererJCommodity : JCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererJournal : JournalDTO
    {
    }
}
