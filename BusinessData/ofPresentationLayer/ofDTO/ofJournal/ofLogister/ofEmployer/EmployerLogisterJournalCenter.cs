using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofLogister.ofEmployer
{
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterJournalCenter : LogisterJournalCenter
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterJCommodity : LogisterJCommodity
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterJournal : LogisterJournal
    {
    }
}
