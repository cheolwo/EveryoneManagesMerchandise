using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWarehouse
{
    public class PlatformWarehousePageViewModel : CenterPageViewModel<PlatformWarehouse> 
    {
        public readonly PlatformPostWarehouseViewModel _PlatformPostWarehouseViewModel;
        public readonly PlatformPutWarehouseViewModel _PlatformPutWarehouseViewModel;
        public readonly PlatformDeleteWarehouseViewModel _PlatformDeleteWarehouseViewModel;
        public readonly PlatformGetsWarehouseViewModel _PlatformGetsWarehouseViewModel;
        public PlatformWarehousePageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostWarehouseViewModel PlatformPostWarehouseViewModel, 
                                        PlatformPutWarehouseViewModel PlatformPutWarehouseViewModel,
                                        PlatformDeleteWarehouseViewModel PlatformDeleteWarehouseViewModel,
                                        PlatformGetsWarehouseViewModel PlatformGetsWarehouseViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostWarehouseViewModel, PlatformPutWarehouseViewModel, PlatformDeleteWarehouseViewModel, PlatformGetsWarehouseViewModel)
                    
        {
            _PlatformPostWarehouseViewModel = PlatformPostWarehouseViewModel;
            _PlatformPutWarehouseViewModel = PlatformPutWarehouseViewModel;
            _PlatformDeleteWarehouseViewModel = PlatformDeleteWarehouseViewModel;
            _PlatformGetsWarehouseViewModel = PlatformGetsWarehouseViewModel;
        }
    }
}