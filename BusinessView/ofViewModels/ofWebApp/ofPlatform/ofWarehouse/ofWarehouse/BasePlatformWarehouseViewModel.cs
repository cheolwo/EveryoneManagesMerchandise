using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformWarehouseViewModel : BaseCenterViewModel<PlatformWarehouse>
    {
        public BasePlatformWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostWarehouseViewModel : CenterPostViewModel<PlatformWarehouse>
    {
        public PlatformPostWarehouseViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutWarehouseViewModel : CenterPutViewModel<PlatformWarehouse>
    {
        public PlatformPutWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteWarehouseViewModel : CenterDeleteViewModel<PlatformWarehouse>
    {
        public PlatformDeleteWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsWarehouseViewModel : CenterGetsViewModel<PlatformWarehouse>
    {
        public PlatformGetsWarehouseViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
