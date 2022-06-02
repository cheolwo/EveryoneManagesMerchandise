using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC
{
    public class MGOCPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MGOCPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MGOCDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MGOCGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}