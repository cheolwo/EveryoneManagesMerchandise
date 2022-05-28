using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse
{
    public class WarehousePostViewModel<TSStatus> : SStatusPostViewModel<TSStatus> where TSStatus : WarehouseDTO, new()
    {
        public WarehousePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WarehousePutViewModel<TSStatus> : SStatusPutViewModel<TSStatus> where TSStatus : WarehouseDTO, new()
    {
        public WarehousePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WarehouseDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus> where TSStatus : WarehouseDTO, new()
    {
        public WarehouseDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class WarehouseGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus> where TSStatus : WarehouseDTO, new()
    {
        public WarehouseGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}