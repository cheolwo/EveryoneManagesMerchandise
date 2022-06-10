using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofSeller.ofEmployee
{
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerJournalCenter : SellerJournalCenter
    {
    }
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerJCommodity : SellerJCommodity
    {
    }
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerJournal : SellerJournal
    {
    }
}
