using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWarehouse
{
    public class EmployeeWarehousePageViewModel : CenterPageViewModel<EmployeeWarehouse> 
    {
        public EmployeeWarehousePageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostWarehouseViewModel employeePostWarehouseViewModel, 
                                        EmployeePutWarehouseViewModel employeePutWarehouseViewModel,
                                        EmployeeDeleteWarehouseViewModel employeeDeleteWarehouseViewModel,
                                        EmployeeGetsWarehouseViewModel employeeGetsWarehouseViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostWarehouseViewModel, employeePutWarehouseViewModel, employeeDeleteWarehouseViewModel, employeeGetsWarehouseViewModel)
                    
        {
            
        }
    }
}