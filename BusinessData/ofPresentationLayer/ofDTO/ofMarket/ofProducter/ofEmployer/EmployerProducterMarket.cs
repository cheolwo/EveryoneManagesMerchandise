using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofProducter.ofEmployer
{
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterMarket : ProducterMarket
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterPlatMarket : ProducterPlatMarket
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterMCommodity : ProducterMCommodity
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterSMCommodity : ProducterSMCommodity
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterMMCommodity : ProducterMMCommodity
    {
    }
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerProducterEMCommodity : ProducterEMCommodity
    {
    }
}
