﻿using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHREmployee
{
    public class EmployeeHREmployeePageViewModel : EntityPageViewModel<EmployeeHREmployee> 
    {
        public readonly EmployeePostHREmployeeViewModel _EmployeePostHREmployeeViewModel;
        public readonly EmployeePutHREmployeeViewModel _EmployeePutHREmployeeViewModel;
        public readonly EmployeeDeleteHREmployeeViewModel _EmployeeDeleteHREmployeeViewModel;
        public readonly EmployeeGetsHREmployeeViewModel _EmployeeGetsHREmployeeViewModel;
        public EmployeeHREmployeePageViewModel(EmployeePostHREmployeeViewModel employeePostHREmployeeViewModel, 
                                        EmployeePutHREmployeeViewModel employeePutHREmployeeViewModel,
                                        EmployeeDeleteHREmployeeViewModel employeeDeleteHREmployeeViewModel,
                                        EmployeeGetsHREmployeeViewModel employeeGetsHREmployeeViewModel)
                :base(employeePostHREmployeeViewModel, employeePutHREmployeeViewModel, employeeDeleteHREmployeeViewModel, employeeGetsHREmployeeViewModel)
                    
        {
            _EmployeePostHREmployeeViewModel = employeePostHREmployeeViewModel;
            _EmployeePutHREmployeeViewModel = employeePutHREmployeeViewModel;
            _EmployeeDeleteHREmployeeViewModel = employeeDeleteHREmployeeViewModel;
            _EmployeeGetsHREmployeeViewModel = employeeGetsHREmployeeViewModel;
        }
    }
}