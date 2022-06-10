using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerGOC : GOCDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerGOCC : EGOCDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerSGOC : SGOCDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerMGOC : MGOCDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerEGOC : EGOCDTO
    {
    }
}
