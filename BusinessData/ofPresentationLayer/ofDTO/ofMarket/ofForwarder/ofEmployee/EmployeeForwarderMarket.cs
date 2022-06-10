using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofForwarder.ofEmployee
{
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderMarket : ForwarderMarket
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderPlatMarket : ForwarderPlatMarket
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderMCommodity : ForwarderMCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderSMCommodity : ForwarderSMCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderMMCommodity : ForwarderMMCommodity
    {
    }
    [ActorContext(typeof(EmployeeForwarderContext))]
    public class EmployeeForwarderEMCommodity : ForwarderEMCommodity
    {
    }
}
