using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity
{
    public class EMCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EMCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EMCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class EMCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}