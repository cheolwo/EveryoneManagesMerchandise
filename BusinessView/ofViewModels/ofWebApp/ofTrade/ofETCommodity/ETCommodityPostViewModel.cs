using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofETCommodity
{
    public class ETCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : ETCommodityDTO, new()
    {
        public ETCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ETCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : ETCommodityDTO, new()
    {
        public ETCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ETCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : ETCommodityDTO, new()
    {
        public ETCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class ETCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : ETCommodityDTO, new()
    {
        public ETCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}