using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerJournalCenter : JournalCenterDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerJCommodity : JCommodityDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerJournal : JournalDTO
    {
    }
}
