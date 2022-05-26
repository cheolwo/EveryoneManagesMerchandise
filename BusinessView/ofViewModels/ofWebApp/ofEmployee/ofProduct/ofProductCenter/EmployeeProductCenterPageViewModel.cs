using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductCenter
{
    public class EmployeeProductCenterPageViewModel : CenterPageViewModel<EmployeeProductCenter> 
    {
        public readonly EmployeePostProductCenterViewModel _EmployeePostProductCenterViewModel;
        public readonly EmployeePutProductCenterViewModel _EmployeePutProductCenterViewModel;
        public readonly EmployeeDeleteProductCenterViewModel _EmployeeDeleteProductCenterViewModel;
        public readonly EmployeeGetsProductCenterViewModel _EmployeeGetsProductCenterViewModel;
        public EmployeeProductCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostProductCenterViewModel employeePostProductCenterViewModel, 
                                        EmployeePutProductCenterViewModel employeePutProductCenterViewModel,
                                        EmployeeDeleteProductCenterViewModel employeeDeleteProductCenterViewModel,
                                        EmployeeGetsProductCenterViewModel employeeGetsProductCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostProductCenterViewModel, employeePutProductCenterViewModel, employeeDeleteProductCenterViewModel, employeeGetsProductCenterViewModel)
                    
        {
            _EmployeePostProductCenterViewModel = employeePostProductCenterViewModel;
            _EmployeePutProductCenterViewModel = employeePutProductCenterViewModel;
            _EmployeeDeleteProductCenterViewModel = employeeDeleteProductCenterViewModel;
            _EmployeeGetsProductCenterViewModel = employeeGetsProductCenterViewModel;
        }
    }
}