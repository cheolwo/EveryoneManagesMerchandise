using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse
{
    public class WarehousePostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : WarehouseDTO, new()
    {
        public WarehousePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WarehousePutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : WarehouseDTO, new()
    {
        public WarehousePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WarehouseDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : WarehouseDTO, new()
    {
        public WarehouseDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class WarehouseGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : WarehouseDTO, new()
    {
        public WarehouseGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}