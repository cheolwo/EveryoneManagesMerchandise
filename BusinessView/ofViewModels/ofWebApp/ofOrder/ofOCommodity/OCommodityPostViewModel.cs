using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity
{
    public class OCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class OCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class OCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class OCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}