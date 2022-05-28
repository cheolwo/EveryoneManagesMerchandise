using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity
{
    public class EWCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus> where TEStatus : EWCommodityDTO, new()
    {
        public EWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EWCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus> where TEStatus : EWCommodityDTO, new()
    {
        public EWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EWCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus> where TEStatus : EWCommodityDTO, new()
    {
        public EWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class EWCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus> where TEStatus : EWCommodityDTO, new()
    {
        public EWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}