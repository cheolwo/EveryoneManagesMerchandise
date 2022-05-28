using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC
{
    public class GOCPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class GOCPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class GOCDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class GOCGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : GOCDTO, new()
    {
        public GOCGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}