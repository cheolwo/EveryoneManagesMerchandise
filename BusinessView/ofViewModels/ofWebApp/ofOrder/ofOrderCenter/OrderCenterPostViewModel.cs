using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter
{
    public class OrderCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class OrderCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class OrderCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class OrderCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}