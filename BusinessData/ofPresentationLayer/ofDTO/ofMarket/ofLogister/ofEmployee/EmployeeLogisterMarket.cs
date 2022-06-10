using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofLogister.ofEmployee
{
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterMarket : LogisterMarket
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterPlatMarket : LogisterPlatMarket
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterMCommodity : LogisterMCommodity
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterSMCommodity : LogisterSMCommodity
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterMMCommodity : LogisterMMCommodity
    {
    }
    [ActorContext(typeof(EmployeeLogisterContext))]
    public class EmployeeLogisterEMCommodity : LogisterEMCommodity
    {
    }
}
