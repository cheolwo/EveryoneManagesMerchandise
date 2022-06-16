using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC
{
    public class SGOCPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SGOCPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SGOCDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SGOCGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}