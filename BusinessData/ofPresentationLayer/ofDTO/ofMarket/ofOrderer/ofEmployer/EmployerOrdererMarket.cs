using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofOrderer.ofEmployer
{
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererMarket : OrdererMarket
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererPlatMarket : OrdererPlatMarket
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererMCommodity : OrdererMCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererSMCommodity : OrdererSMCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererMMCommodity : OrdererMMCommodity
    {
    }
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrdererEMCommodity : OrdererEMCommodity
    {
    }
}
