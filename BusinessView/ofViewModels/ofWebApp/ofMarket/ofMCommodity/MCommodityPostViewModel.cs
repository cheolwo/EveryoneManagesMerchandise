using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity
{
    public class MCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}