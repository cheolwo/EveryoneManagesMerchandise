using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofEPCommodity
{
    public class EPCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EPCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EPCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class EPCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}