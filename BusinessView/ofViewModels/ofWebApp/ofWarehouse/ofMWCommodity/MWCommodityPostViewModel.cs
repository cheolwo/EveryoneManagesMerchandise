using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity
{
    public class MWCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : MWCommodityDTO, new()
    {
        public MWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MWCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : MWCommodityDTO, new()
    {
        public MWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MWCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : MWCommodityDTO, new()
    {
        public MWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MWCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : MWCommodityDTO, new()
    {
        public MWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}