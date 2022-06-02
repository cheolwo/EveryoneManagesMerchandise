using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC
{
    public class GOCCPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class GOCCPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class GOCCDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class GOCCGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}