using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofPCommodity
{
    public class PCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class PCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class PCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class PCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}