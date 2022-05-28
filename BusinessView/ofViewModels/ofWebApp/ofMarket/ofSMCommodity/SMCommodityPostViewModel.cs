using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity
{
    public class SMCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SMCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SMCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SMCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : SMCommodityDTO, new()
    {
        public SMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}