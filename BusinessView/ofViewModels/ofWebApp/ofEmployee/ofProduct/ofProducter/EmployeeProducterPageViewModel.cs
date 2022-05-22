using BusinessLogic.ofExternal.ofSearchingService;
using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProducter
{
    public class EmployeeProducterPageViewModel : CenterPageViewModel<EmployeeProducter> 
    {
        public readonly EmployeePostProducterViewModel _EmployeePostProducterViewModel;
        public readonly EmployeePutProducterViewModel _EmployeePutProducterViewModel;
        public readonly EmployeeDeleteProducterViewModel _EmployeeDeleteProducterViewModel;
        public readonly EmployeeGetsProducterViewModel _EmployeeGetsProducterViewModel;
        public EmployeeProducterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostProducterViewModel employeePostProducterViewModel, 
                                        EmployeePutProducterViewModel employeePutProducterViewModel,
                                        EmployeeDeleteProducterViewModel employeeDeleteProducterViewModel,
                                        EmployeeGetsProducterViewModel employeeGetsProducterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostProducterViewModel, employeePutProducterViewModel, employeeDeleteProducterViewModel, employeeGetsProducterViewModel)
                    
        {
            _EmployeePostProducterViewModel = employeePostProducterViewModel;
            _EmployeePutProducterViewModel = employeePutProducterViewModel;
            _EmployeeDeleteProducterViewModel = employeeDeleteProducterViewModel;
            _EmployeeGetsProducterViewModel = employeeGetsProducterViewModel;
        }
    }
}