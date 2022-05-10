using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJournalCenter
{
    public class EmployeeJournalCenterPageViewModel : CenterPageViewModel<EmployeeJournalCenter> 
    {
        public EmployeeJournalCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostJournalCenterViewModel employeePostJournalCenterViewModel, 
                                        EmployeePutJournalCenterViewModel employeePutJournalCenterViewModel,
                                        EmployeeDeleteJournalCenterViewModel employeeDeleteJournalCenterViewModel,
                                        EmployeeGetsJournalCenterViewModel employeeGetsJournalCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostJournalCenterViewModel, employeePutJournalCenterViewModel, employeeDeleteJournalCenterViewModel, employeeGetsJournalCenterViewModel)
                    
        {
            
        }
    }
}