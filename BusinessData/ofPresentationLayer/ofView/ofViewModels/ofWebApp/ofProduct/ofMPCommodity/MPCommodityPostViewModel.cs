using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity
{
    public class MPCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MPCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MPCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MPCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}