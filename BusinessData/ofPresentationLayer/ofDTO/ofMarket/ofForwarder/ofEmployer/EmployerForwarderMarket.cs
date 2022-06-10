using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofForwarder.ofEmployer
{
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderMarket : ForwarderMarket
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderPlatMarket : ForwarderPlatMarket
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderMCommodity : ForwarderMCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderSMCommodity : ForwarderSMCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderMMCommodity : ForwarderMMCommodity
    {
    }
    [ActorContext(typeof(EmployerForwarderContext))]
    public class EmployerForwarderEMCommodity : ForwarderEMCommodity
    {
    }
}
