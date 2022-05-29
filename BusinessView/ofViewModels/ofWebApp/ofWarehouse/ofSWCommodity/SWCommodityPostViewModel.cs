using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity
{
    public class SWCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus> where TSStatus : SWCommodityDTO, new()
    {
        public SWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SWCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus> where TSStatus : SWCommodityDTO, new()
    {
        public SWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SWCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus> where TSStatus : SWCommodityDTO, new()
    {
        public SWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SWCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus> where TSStatus : SWCommodityDTO, new()
    {
        public SWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}