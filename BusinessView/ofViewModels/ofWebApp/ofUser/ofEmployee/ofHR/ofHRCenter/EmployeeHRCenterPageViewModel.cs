using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRCenter
{
    public class EmployeeHRCenterPageViewModel : CenterPageViewModel<EmployeeHRCenter> 
    {
        public readonly EmployeePostHRCenterViewModel _EmployeePostHRCenterViewModel;
        public readonly EmployeePutHRCenterViewModel _EmployeePutHRCenterViewModel;
        public readonly EmployeeDeleteHRCenterViewModel _EmployeeDeleteHRCenterViewModel;
        public readonly EmployeeGetsHRCenterViewModel _EmployeeGetsHRCenterViewModel;
        public EmployeeHRCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployeePostHRCenterViewModel employeePostHRCenterViewModel, 
                                        EmployeePutHRCenterViewModel employeePutHRCenterViewModel,
                                        EmployeeDeleteHRCenterViewModel employeeDeleteHRCenterViewModel,
                                        EmployeeGetsHRCenterViewModel employeeGetsHRCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostHRCenterViewModel, employeePutHRCenterViewModel, employeeDeleteHRCenterViewModel, employeeGetsHRCenterViewModel)
                    
        {
            _EmployeePostHRCenterViewModel = employeePostHRCenterViewModel;
            _EmployeePutHRCenterViewModel = employeePutHRCenterViewModel;
            _EmployeeDeleteHRCenterViewModel = employeeDeleteHRCenterViewModel;
            _EmployeeGetsHRCenterViewModel = employeeGetsHRCenterViewModel;
        }
    }
}