using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC
{
    public class GOCPostViewModel<TEStatus> : CenterPostViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class GOCPutViewModel<TEStatus> : CenterPutViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class GOCDeleteViewModel<TEStatus> : CenterDeleteViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class GOCGetsViewModel<TEStatus> : CenterGetsViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}