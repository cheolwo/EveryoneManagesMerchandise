using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWarehouse
{
    public class PlatformWarehousePageViewModel : CenterPageViewModel<PlatformWarehouse> 
    {
        public PlatformWarehousePageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostWarehouseViewModel PlatformPostWarehouseViewModel, 
                                        PlatformPutWarehouseViewModel PlatformPutWarehouseViewModel,
                                        PlatformDeleteWarehouseViewModel PlatformDeleteWarehouseViewModel,
                                        PlatformGetsWarehouseViewModel PlatformGetsWarehouseViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostWarehouseViewModel, PlatformPutWarehouseViewModel, PlatformDeleteWarehouseViewModel, PlatformGetsWarehouseViewModel)
                    
        {
            
        }
    }
}