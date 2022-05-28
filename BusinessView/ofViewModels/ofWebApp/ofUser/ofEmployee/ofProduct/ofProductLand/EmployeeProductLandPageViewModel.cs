using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductLand;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductLand
{
    public class EmployeeProductLandPageViewModel : ProductLandPageViewModel<EmployeeProductLand> 
    {
        public readonly EmployeePostProductLandViewModel _EmployeePostProductLandViewModel;
        public readonly EmployeePutProductLandViewModel _EmployeePutProductLandViewModel;
        public readonly EmployeeDeleteProductLandViewModel _EmployeeDeleteProductLandViewModel;
        public readonly EmployeeGetsProductLandViewModel _EmployeeGetsProductLandViewModel;
        public EmployeeProductLandPageViewModel(EmployeePostProductLandViewModel employeePostProductLandViewModel, 
                                        EmployeePutProductLandViewModel employeePutProductLandViewModel,
                                        EmployeeDeleteProductLandViewModel employeeDeleteProductLandViewModel,
                                        EmployeeGetsProductLandViewModel employeeGetsProductLandViewModel)
                :base(employeePostProductLandViewModel, employeePutProductLandViewModel, employeeDeleteProductLandViewModel, employeeGetsProductLandViewModel)
                    
        {
            _EmployeePostProductLandViewModel = employeePostProductLandViewModel;
            _EmployeePutProductLandViewModel = employeePutProductLandViewModel;
            _EmployeeDeleteProductLandViewModel = employeeDeleteProductLandViewModel;
            _EmployeeGetsProductLandViewModel = employeeGetsProductLandViewModel;
        }
    }
}