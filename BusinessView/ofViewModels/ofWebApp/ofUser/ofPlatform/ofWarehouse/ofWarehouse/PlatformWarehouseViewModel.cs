using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostWarehouseViewModel : WarehousePostViewModel<PlatformWarehouse>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostWarehouseViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutWarehouseViewModel : WarehousePutViewModel<PlatformWarehouse>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteWarehouseViewModel : WarehouseDeleteViewModel<PlatformWarehouse>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsWarehouseViewModel : WarehouseGetsViewModel<PlatformWarehouse>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
