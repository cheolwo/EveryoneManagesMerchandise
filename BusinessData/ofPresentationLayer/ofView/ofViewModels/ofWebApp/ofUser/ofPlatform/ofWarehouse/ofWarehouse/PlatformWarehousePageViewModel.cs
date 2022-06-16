using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWarehouse
{
    public class PlatformWarehousePageViewModel : WarehousePageViewModel<PlatformWarehouse> 
    {
        public readonly PlatformPostWarehouseViewModel _PlatformPostWarehouseViewModel;
        public readonly PlatformPutWarehouseViewModel _PlatformPutWarehouseViewModel;
        public readonly PlatformDeleteWarehouseViewModel _PlatformDeleteWarehouseViewModel;
        public readonly PlatformGetsWarehouseViewModel _PlatformGetsWarehouseViewModel;

        public PlatformWarehousePageViewModel(PlatformPostWarehouseViewModel PlatformPostWarehouseViewModel, 
                                        PlatformPutWarehouseViewModel PlatformPutWarehouseViewModel,
                                        PlatformDeleteWarehouseViewModel PlatformDeleteWarehouseViewModel,
                                        PlatformGetsWarehouseViewModel PlatformGetsWarehouseViewModel)
                :base(PlatformPostWarehouseViewModel, PlatformPutWarehouseViewModel, PlatformDeleteWarehouseViewModel, PlatformGetsWarehouseViewModel)
                    
        {
            _PlatformPostWarehouseViewModel = PlatformPostWarehouseViewModel;
            _PlatformPutWarehouseViewModel = PlatformPutWarehouseViewModel;
            _PlatformDeleteWarehouseViewModel = PlatformDeleteWarehouseViewModel;
            _PlatformGetsWarehouseViewModel = PlatformGetsWarehouseViewModel;
        }
    }
}