using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMMCommodity
{
    public class MMCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MMCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MMCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MMCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}