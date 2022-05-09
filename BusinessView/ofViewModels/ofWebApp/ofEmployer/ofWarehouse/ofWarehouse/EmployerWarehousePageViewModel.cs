using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWarehouse
{
    public class EmployerWarehousePageViewModel : CenterPageViewModel<EmployerWarehouse> 
    {
        public EmployerWarehousePageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostWarehouseViewModel EmployerPostWarehouseViewModel, 
                                        EmployerPutWarehouseViewModel EmployerPutWarehouseViewModel,
                                        EmployerDeleteWarehouseViewModel EmployerDeleteWarehouseViewModel,
                                        EmployerGetsWarehouseViewModel EmployerGetsWarehouseViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostWarehouseViewModel, EmployerPutWarehouseViewModel, EmployerDeleteWarehouseViewModel, EmployerGetsWarehouseViewModel)
                    
        {
            
        }
    }
}