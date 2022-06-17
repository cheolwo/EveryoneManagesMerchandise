using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC
{
    public class EGOCPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCPostViewModel()
            :base(actorContext)
        {

        }
    }
    public class EGOCPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCPutViewModel()
            :base(actorContext)
        {

        }
    }
    public class EGOCDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCDeleteViewModel()
            :base(actorContext)
        {
             
        }
    }
    public class EGOCGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCGetsViewModel()
            :base(actorContext)
        {

        }
    }
}