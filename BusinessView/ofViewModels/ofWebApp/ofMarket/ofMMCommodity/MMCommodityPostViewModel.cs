using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMMCommodity
{
    public class MMCommodityPostViewModel<TCommodity> : MStatusPostViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MMCommodityPutViewModel<TCommodity> : MStatusPutViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MMCommodityDeleteViewModel<TCommodity> : MStatusDeleteViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MMCommodityGetsViewModel<TCommodity> : MStatusGetsViewModel<TCommodity> where TCommodity : MMCommodityDTO, new()
    {
        public MMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}