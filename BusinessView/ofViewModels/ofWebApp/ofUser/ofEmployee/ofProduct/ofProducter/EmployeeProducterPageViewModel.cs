using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProducter
{
    public class EmployeeProducterPageViewModel : ProducterPageViewModel<EmployeeProducter> 
    {
        public readonly EmployeePostProducterViewModel _EmployeePostProducterViewModel;
        public readonly EmployeePutProducterViewModel _EmployeePutProducterViewModel;
        public readonly EmployeeDeleteProducterViewModel _EmployeeDeleteProducterViewModel;
        public readonly EmployeeGetsProducterViewModel _EmployeeGetsProducterViewModel;
        public EmployeeProducterPageViewModel(
            EmployeePostProducterViewModel employeePostProducterViewModel, 
                                        EmployeePutProducterViewModel employeePutProducterViewModel,
                                        EmployeeDeleteProducterViewModel employeeDeleteProducterViewModel,
                                        EmployeeGetsProducterViewModel employeeGetsProducterViewModel)
                :base(employeePostProducterViewModel, employeePutProducterViewModel, employeeDeleteProducterViewModel, employeeGetsProducterViewModel)
                    
        {
            _EmployeePostProducterViewModel = employeePostProducterViewModel;
            _EmployeePutProducterViewModel = employeePutProducterViewModel;
            _EmployeeDeleteProducterViewModel = employeeDeleteProducterViewModel;
            _EmployeeGetsProducterViewModel = employeeGetsProducterViewModel;
        }
    }
}