using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofLogister.ofEmployee
{
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterJournalCenter : LogisterJournalCenter
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterJCommodity : LogisterJCommodity
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterJournal : LogisterJournal
    {
    }
}
