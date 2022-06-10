using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofForwarder.ofEmployer
{
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderOrderCenter : ForwarderOrderCenter
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderOCommodity : ForwarderOCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderSOCommodity : ForwarderSOCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderMOCommodity : ForwarderMOCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderEOCommodity : ForwarderEOCommodity
    {
    }
}
