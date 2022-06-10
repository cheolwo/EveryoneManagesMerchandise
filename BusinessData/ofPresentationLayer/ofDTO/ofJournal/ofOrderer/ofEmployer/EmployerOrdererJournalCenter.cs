using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofOrderer.ofEmployer
{
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererJournalCenter : OrdererJournalCenter
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererJCommodity : OrdererJCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererJournal : OrdererJournal
    {
    }
}
