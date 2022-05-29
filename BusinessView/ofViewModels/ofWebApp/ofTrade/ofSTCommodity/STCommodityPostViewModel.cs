using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofSTCommodity
{
    public class STCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus> where TSStatus : STCommodityDTO, new()
    {
        public STCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class STCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus> where TSStatus : STCommodityDTO, new()
    {
        public STCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class STCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus> where TSStatus : STCommodityDTO, new()
    {
        public STCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class STCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus> where TSStatus : STCommodityDTO, new()
    {
        public STCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}