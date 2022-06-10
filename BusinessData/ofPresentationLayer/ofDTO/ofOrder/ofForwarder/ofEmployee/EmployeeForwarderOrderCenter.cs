using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofForwarder.ofEmployee
{
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderOrderCenter : ForwarderOrderCenter
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderOCommodity : ForwarderOCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderSOCommodity : ForwarderSOCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderMOCommodity : ForwarderMOCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderEOCommodity : ForwarderEOCommodity
    {
    }
}
