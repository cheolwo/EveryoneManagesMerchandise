using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofTCommodity
{
    public class TCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : TCommodityDTO, new()
    {
        public TCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class TCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : TCommodityDTO, new()
    {
        public TCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class TCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : TCommodityDTO, new()
    {
        public TCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class TCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : TCommodityDTO, new()
    {
        public TCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}