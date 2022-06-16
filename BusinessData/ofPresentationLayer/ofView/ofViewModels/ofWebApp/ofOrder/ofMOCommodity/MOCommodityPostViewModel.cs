using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity
{
    public class MOCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MOCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MOCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MOCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}