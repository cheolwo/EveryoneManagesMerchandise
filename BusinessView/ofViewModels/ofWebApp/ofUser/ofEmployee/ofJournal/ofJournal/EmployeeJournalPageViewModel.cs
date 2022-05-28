﻿using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJournal
{
    public class EmployeeJournalPageViewModel : JournalPageViewModel<EmployeeJournal> 
    {
        public readonly EmployeePostJournalViewModel _EmployeePostJournalViewModel;
        public readonly EmployeePutJournalViewModel _EmployeePutJournalViewModel;
        public readonly EmployeeDeleteJournalViewModel _EmployeeDeleteJournalViewModel;
        public readonly EmployeeGetsJournalViewModel _EmployeeGetsJournalViewModel;
        public EmployeeJournalPageViewModel(EmployeePostJournalViewModel employeePostJournalViewModel, 
                                        EmployeePutJournalViewModel employeePutJournalViewModel,
                                        EmployeeDeleteJournalViewModel employeeDeleteJournalViewModel,
                                        EmployeeGetsJournalViewModel employeeGetsJournalViewModel)
                :base(employeePostJournalViewModel, employeePutJournalViewModel, employeeDeleteJournalViewModel, employeeGetsJournalViewModel)
                    
        {
            _EmployeePostJournalViewModel = employeePostJournalViewModel;
            _EmployeePutJournalViewModel = employeePutJournalViewModel;
            _EmployeeDeleteJournalViewModel = employeeDeleteJournalViewModel;
            _EmployeeGetsJournalViewModel = employeeGetsJournalViewModel;
        }
    }
}