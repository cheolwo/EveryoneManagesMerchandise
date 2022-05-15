using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWarehouse
{
    public class EmployerWarehousePageViewModel : CenterPageViewModel<EmployerWarehouse> 
    {
        public readonly EmployerPostWarehouseViewModel _EmployerPostWarehouseViewModel;
        public readonly EmployerPutWarehouseViewModel _EmployerPutWarehouseViewModel;
        public readonly EmployerDeleteWarehouseViewModel _EmployerDeleteWarehouseViewModel;
        public readonly EmployerGetsWarehouseViewModel _EmployerGetsWarehouseViewModel;
        public EmployerWarehousePageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostWarehouseViewModel EmployerPostWarehouseViewModel, 
                                        EmployerPutWarehouseViewModel EmployerPutWarehouseViewModel,
                                        EmployerDeleteWarehouseViewModel EmployerDeleteWarehouseViewModel,
                                        EmployerGetsWarehouseViewModel EmployerGetsWarehouseViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostWarehouseViewModel, EmployerPutWarehouseViewModel, EmployerDeleteWarehouseViewModel, EmployerGetsWarehouseViewModel)
                    
        {
             _EmployerPostWarehouseViewModel = EmployerPostWarehouseViewModel;
            _EmployerPutWarehouseViewModel = EmployerPutWarehouseViewModel;
            _EmployerDeleteWarehouseViewModel = EmployerDeleteWarehouseViewModel;
            _EmployerGetsWarehouseViewModel = EmployerGetsWarehouseViewModel;
        }
    }
}