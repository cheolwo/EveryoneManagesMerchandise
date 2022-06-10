using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofProducter.ofEmployer
{
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterJournalCenter : ProducterJournalCenter
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterJCommodity : ProducterJCommodity
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterJournal : ProducterJournal
    {
    }
}
