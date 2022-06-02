using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

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