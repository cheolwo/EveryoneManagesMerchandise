using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity
{
    public class OCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus> where TMStatus : OCommodityDTO, new()
    {
        public OCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class OCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus> where TMStatus : OCommodityDTO, new()
    {
        public OCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class OCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus> where TMStatus : OCommodityDTO, new()
    {
        public OCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class OCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus> where TMStatus : OCommodityDTO, new()
    {
        public OCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}