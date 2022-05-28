using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofEOCommodity
{
    public class EOCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EOCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EOCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class EOCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}