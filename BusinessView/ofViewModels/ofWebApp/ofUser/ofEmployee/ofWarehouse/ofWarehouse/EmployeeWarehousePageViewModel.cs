using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWarehouse
{
    public class EmployeeWarehousePageViewModel : CenterPageViewModel<EmployeeWarehouse> 
    {
        public readonly EmployeePostWarehouseViewModel _EmployeePostWarehouseViewModel;
        public readonly EmployeePutWarehouseViewModel _EmployeePutWarehouseViewModel;
        public readonly EmployeeDeleteWarehouseViewModel _EmployeeDeleteWarehouseViewModel;
        public readonly EmployeeGetsWarehouseViewModel _EmployeeGetsWarehouseViewModel;
        public EmployeeWarehousePageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostWarehouseViewModel employeePostWarehouseViewModel, 
                                        EmployeePutWarehouseViewModel employeePutWarehouseViewModel,
                                        EmployeeDeleteWarehouseViewModel employeeDeleteWarehouseViewModel,
                                        EmployeeGetsWarehouseViewModel employeeGetsWarehouseViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostWarehouseViewModel, employeePutWarehouseViewModel, employeeDeleteWarehouseViewModel, employeeGetsWarehouseViewModel)
                    
        {
            _EmployeePostWarehouseViewModel = employeePostWarehouseViewModel;
            _EmployeePutWarehouseViewModel = employeePutWarehouseViewModel;
            _EmployeeDeleteWarehouseViewModel = employeeDeleteWarehouseViewModel;
            _EmployeeGetsWarehouseViewModel = employeeGetsWarehouseViewModel;
        }
    }
}