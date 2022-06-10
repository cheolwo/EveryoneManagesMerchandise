using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofLogister.ofEmployer
{
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterMarket : LogisterMarket
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterPlatMarket : LogisterPlatMarket
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterMCommodity : LogisterMCommodity
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterSMCommodity : LogisterSMCommodity
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterMMCommodity : LogisterMMCommodity
    {
    }
    [ActorContext(typeof(EmployerLogisterContext))]
    public class EmployerLogisterEMCommodity : LogisterEMCommodity
    {
    }
}
