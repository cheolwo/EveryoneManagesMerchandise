﻿using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRCenter
{
    public class EmployeeHRCenterPageViewModel : HRCenterPageViewModel<EmployeeHRCenter> 
    {
        public readonly EmployeePostHRCenterViewModel _EmployeePostHRCenterViewModel;
        public readonly EmployeePutHRCenterViewModel _EmployeePutHRCenterViewModel;
        public readonly EmployeeDeleteHRCenterViewModel _EmployeeDeleteHRCenterViewModel;
        public readonly EmployeeGetsHRCenterViewModel _EmployeeGetsHRCenterViewModel;
        public EmployeeHRCenterPageViewModel(
                                        EmployeePostHRCenterViewModel employeePostHRCenterViewModel, 
                                        EmployeePutHRCenterViewModel employeePutHRCenterViewModel,
                                        EmployeeDeleteHRCenterViewModel employeeDeleteHRCenterViewModel,
                                        EmployeeGetsHRCenterViewModel employeeGetsHRCenterViewModel)
                :base(employeePostHRCenterViewModel, employeePutHRCenterViewModel, employeeDeleteHRCenterViewModel, employeeGetsHRCenterViewModel)
                    
        {
            _EmployeePostHRCenterViewModel = employeePostHRCenterViewModel;
            _EmployeePutHRCenterViewModel = employeePutHRCenterViewModel;
            _EmployeeDeleteHRCenterViewModel = employeeDeleteHRCenterViewModel;
            _EmployeeGetsHRCenterViewModel = employeeGetsHRCenterViewModel;
        }
    }
}