using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity
{
    public class WCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : WCommodityDTO, new()
    {
        public WCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : WCommodityDTO, new()
    {
        public WCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : WCommodityDTO, new()
    {
        public WCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class WCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : WCommodityDTO, new()
    {
        public WCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}