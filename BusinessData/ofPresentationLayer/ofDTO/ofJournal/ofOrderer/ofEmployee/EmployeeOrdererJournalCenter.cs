using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofOrderer.ofEmployee
{
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererJournalCenter : OrdererJournalCenter
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererJCommodity : OrdererJCommodity
    {
    }
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrdererJournal : OrdererJournal
    {
    }
}
