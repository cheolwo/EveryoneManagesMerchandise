using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofSeller.ofPlatform
{
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerJournalCenter : SellerJournalCenter
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerJCommodity : SellerJCommodity
    {
    }
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformSellerJournal : SellerJournal
    {
    }
}
