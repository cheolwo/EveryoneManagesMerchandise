using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity
{
    public class SMCommodityPostViewModel<TEStatus> : SStatusPostViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SMCommodityPutViewModel<TEStatus> : SStatusPutViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SMCommodityDeleteViewModel<TEStatus> : SStatusDeleteViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SMCommodityGetsViewModel<TEStatus> : SStatusGetsViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}