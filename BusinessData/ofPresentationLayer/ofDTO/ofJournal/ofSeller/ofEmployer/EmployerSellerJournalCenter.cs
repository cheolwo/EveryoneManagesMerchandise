using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofSeller.ofEmployer
{
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerJournalCenter : SellerJournalCenter
    {
    }
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerJCommodity : SellerJCommodity
    {
    }
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerJournal : SellerJournal
    {
    }
}
