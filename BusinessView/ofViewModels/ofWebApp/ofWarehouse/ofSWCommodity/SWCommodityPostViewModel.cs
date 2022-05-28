using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity
{
    public class SWCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : SWCommodityDTO, new()
    {
        public SWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SWCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : SWCommodityDTO, new()
    {
        public SWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SWCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : SWCommodityDTO, new()
    {
        public SWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SWCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : SWCommodityDTO, new()
    {
        public SWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}