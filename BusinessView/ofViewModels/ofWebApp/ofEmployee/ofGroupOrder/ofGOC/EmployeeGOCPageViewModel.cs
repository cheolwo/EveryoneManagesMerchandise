using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessLogic.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOC
{
    public class EmployeeGOCPageViewModel : CenterPageViewModel<EmployeeGOC> 
    {
        public readonly EmployeePostGOCViewModel _EmployeePostGOCViewModel;
        public readonly EmployeePutGOCViewModel _EmployeePutGOCViewModel;
        public readonly EmployeeDeleteGOCViewModel _EmployeeDeleteGOCViewModel;
        public readonly EmployeeGetsGOCViewModel _EmployeeGetsGOCViewModel;

        public EmployeeGOCPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployeePostGOCViewModel employeePostGOCViewModel, 
                                        EmployeePutGOCViewModel employeePutGOCViewModel,
                                        EmployeeDeleteGOCViewModel employeeDeleteGOCViewModel,
                                        EmployeeGetsGOCViewModel employeeGetsGOCViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostGOCViewModel, employeePutGOCViewModel, employeeDeleteGOCViewModel, employeeGetsGOCViewModel)
                    
        {
            _EmployeePostGOCViewModel = employeePostGOCViewModel;
            _EmployeePutGOCViewModel = employeePutGOCViewModel;
            _EmployeeDeleteGOCViewModel = employeeDeleteGOCViewModel;
            _EmployeeGetsGOCViewModel = employeeGetsGOCViewModel;
        }
    }
}