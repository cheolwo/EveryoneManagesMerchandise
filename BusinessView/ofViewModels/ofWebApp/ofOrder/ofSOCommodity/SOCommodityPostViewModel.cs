using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity
{
    public class SOCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SOCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SOCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SOCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}