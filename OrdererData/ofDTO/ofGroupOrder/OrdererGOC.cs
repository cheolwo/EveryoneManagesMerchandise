using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererGOC : GOCDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererGOCC : EGOCDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererSGOC : SGOCDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMGOC : MGOCDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererEGOC : EGOCDTO
    {
    }
}
