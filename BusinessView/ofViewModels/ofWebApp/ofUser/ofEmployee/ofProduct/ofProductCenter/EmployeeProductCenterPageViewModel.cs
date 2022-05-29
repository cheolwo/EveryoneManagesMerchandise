using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductCenter
{
    public class EmployeeProductCenterPageViewModel : ProductCenterPageViewModel<EmployeeProductCenter> 
    {
        public readonly EmployeePostProductCenterViewModel _EmployeePostProductCenterViewModel;
        public readonly EmployeePutProductCenterViewModel _EmployeePutProductCenterViewModel;
        public readonly EmployeeDeleteProductCenterViewModel _EmployeeDeleteProductCenterViewModel;
        public readonly EmployeeGetsProductCenterViewModel _EmployeeGetsProductCenterViewModel;
        public EmployeeProductCenterPageViewModel(
            EmployeePostProductCenterViewModel employeePostProductCenterViewModel, 
                                        EmployeePutProductCenterViewModel employeePutProductCenterViewModel,
                                        EmployeeDeleteProductCenterViewModel employeeDeleteProductCenterViewModel,
                                        EmployeeGetsProductCenterViewModel employeeGetsProductCenterViewModel)
                :base(employeePostProductCenterViewModel, employeePutProductCenterViewModel, employeeDeleteProductCenterViewModel, employeeGetsProductCenterViewModel)
                    
        {
            _EmployeePostProductCenterViewModel = employeePostProductCenterViewModel;
            _EmployeePutProductCenterViewModel = employeePutProductCenterViewModel;
            _EmployeeDeleteProductCenterViewModel = employeeDeleteProductCenterViewModel;
            _EmployeeGetsProductCenterViewModel = employeeGetsProductCenterViewModel;
        }
    }
}