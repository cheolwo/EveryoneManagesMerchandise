using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWarehouse
{
    public class EmployeeWarehousePageViewModel : WarehousePageViewModel<EmployeeWarehouse> 
    {
        public readonly EmployeePostWarehouseViewModel _EmployeePostWarehouseViewModel;
        public readonly EmployeePutWarehouseViewModel _EmployeePutWarehouseViewModel;
        public readonly EmployeeDeleteWarehouseViewModel _EmployeeDeleteWarehouseViewModel;
        public readonly EmployeeGetsWarehouseViewModel _EmployeeGetsWarehouseViewModel;
        public EmployeeWarehousePageViewModel(
            EmployeePostWarehouseViewModel employeePostWarehouseViewModel, 
                                        EmployeePutWarehouseViewModel employeePutWarehouseViewModel,
                                        EmployeeDeleteWarehouseViewModel employeeDeleteWarehouseViewModel,
                                        EmployeeGetsWarehouseViewModel employeeGetsWarehouseViewModel)
                :base(employeePostWarehouseViewModel, employeePutWarehouseViewModel, employeeDeleteWarehouseViewModel, employeeGetsWarehouseViewModel)
                    
        {
            _EmployeePostWarehouseViewModel = employeePostWarehouseViewModel;
            _EmployeePutWarehouseViewModel = employeePutWarehouseViewModel;
            _EmployeeDeleteWarehouseViewModel = employeeDeleteWarehouseViewModel;
            _EmployeeGetsWarehouseViewModel = employeeGetsWarehouseViewModel;
        }
    }
}