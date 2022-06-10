using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofForwarder.ofEmployer
{
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderJournalCenter : ForwarderJournalCenter
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderJCommodity : ForwarderJCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderJournal : ForwarderJournal
    {
    }
}
