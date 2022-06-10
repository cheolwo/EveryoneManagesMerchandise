using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterJournalCenter : JournalCenterDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterJCommodity : JCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterJournal : JournalDTO
    {
    }
}
