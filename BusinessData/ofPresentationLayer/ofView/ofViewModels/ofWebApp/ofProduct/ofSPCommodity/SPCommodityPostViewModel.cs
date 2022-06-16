using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity
{
    public class SPCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SPCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SPCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SPCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}