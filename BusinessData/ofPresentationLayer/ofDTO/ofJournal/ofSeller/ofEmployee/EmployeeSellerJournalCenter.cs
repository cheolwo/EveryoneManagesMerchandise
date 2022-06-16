using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofEmployee;

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
