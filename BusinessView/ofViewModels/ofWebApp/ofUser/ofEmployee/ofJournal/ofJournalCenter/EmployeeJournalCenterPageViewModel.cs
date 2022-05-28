using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJournalCenter
{
    public class EmployeeJournalCenterPageViewModel : JournalCenterPageViewModel<EmployeeJournalCenter> 
    {
        public readonly EmployeePostJournalCenterViewModel _EmployeePostJournalCenterViewModel;
        public readonly EmployeePutJournalCenterViewModel _EmployeePutJournalCenterViewModel;
        public readonly EmployeeDeleteJournalCenterViewModel _EmployeeDeleteJournalCenterViewModel;
        public readonly EmployeeGetsJournalCenterViewModel _EmployeeGetsJournalCenterViewModel;
        public EmployeeJournalCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostJournalCenterViewModel employeePostJournalCenterViewModel, 
                                        EmployeePutJournalCenterViewModel employeePutJournalCenterViewModel,
                                        EmployeeDeleteJournalCenterViewModel employeeDeleteJournalCenterViewModel,
                                        EmployeeGetsJournalCenterViewModel employeeGetsJournalCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostJournalCenterViewModel, employeePutJournalCenterViewModel, employeeDeleteJournalCenterViewModel, employeeGetsJournalCenterViewModel)
                    
        {
            _EmployeePostJournalCenterViewModel = employeePostJournalCenterViewModel;
            _EmployeePutJournalCenterViewModel = employeePutJournalCenterViewModel;
            _EmployeeDeleteJournalCenterViewModel = employeeDeleteJournalCenterViewModel;
            _EmployeeGetsJournalCenterViewModel = employeeGetsJournalCenterViewModel;
        }
    }
}