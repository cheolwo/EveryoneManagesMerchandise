using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofProducter.ofEmployee
{
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterMarket : ProducterMarket
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterPlatMarket : ProducterPlatMarket
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterMCommodity : ProducterMCommodity
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterSMCommodity : ProducterSMCommodity
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterMMCommodity : ProducterMMCommodity
    {
    }
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProducterEMCommodity : ProducterEMCommodity
    {
    }
}
