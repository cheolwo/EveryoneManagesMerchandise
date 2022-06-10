using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofProducter.ofEmployee
{
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterJournalCenter : ProducterJournalCenter
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterJCommodity : ProducterJCommodity
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterJournal : ProducterJournal
    {
    }
}
