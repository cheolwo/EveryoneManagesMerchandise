using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofMTCommodity
{
    public class MTCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : MTCommodityDTO, new()
    {
        public MTCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MTCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : MTCommodityDTO, new()
    {
        public MTCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MTCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : MTCommodityDTO, new()
    {
        public MTCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MTCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : MTCommodityDTO, new()
    {
        public MTCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}