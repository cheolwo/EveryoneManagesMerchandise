using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterGOC : GOCDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterGOCC : EGOCDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterSGOC : SGOCDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMGOC : MGOCDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterEGOC : EGOCDTO
    {
    }
}
