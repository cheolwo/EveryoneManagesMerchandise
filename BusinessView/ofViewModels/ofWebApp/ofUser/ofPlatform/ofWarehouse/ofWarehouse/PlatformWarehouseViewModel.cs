using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;

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
