using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJournal
{
    public class EmployeeJournalPageViewModel : EntityPageViewModel<EmployeeJournal> 
    {
        public EmployeeJournalPageViewModel(EmployeePostJournalViewModel employeePostJournalViewModel, 
                                        EmployeePutJournalViewModel employeePutJournalViewModel,
                                        EmployeeDeleteJournalViewModel employeeDeleteJournalViewModel,
                                        EmployeeGetsJournalViewModel employeeGetsJournalViewModel)
                :base(employeePostJournalViewModel, employeePutJournalViewModel, employeeDeleteJournalViewModel, employeeGetsJournalViewModel)
                    
        {
            
        }
    }
}