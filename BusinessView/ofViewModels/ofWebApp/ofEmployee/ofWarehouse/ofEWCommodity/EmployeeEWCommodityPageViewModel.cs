﻿using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofEWCommodity
{
    public class EmployeeEWCommodityPageViewModel : StatusPageViewModel<EmployeeEWCommodity> 
    {
        public readonly EmployeePostEWCommodityViewModel _EmployeePostEWCommodityViewModel;
        public readonly EmployeePutEWCommodityViewModel _EmployeePutEWCommodityViewModel;
        public readonly EmployeeDeleteEWCommodityViewModel _EmployeeDeleteEWCommodityViewModel;
        public readonly EmployeeGetsEWCommodityViewModel _EmployeeGetsEWCommodityViewModel;
        public EmployeeEWCommodityPageViewModel(EmployeePostEWCommodityViewModel employeePostEWCommodityViewModel, 
                                        EmployeePutEWCommodityViewModel employeePutEWCommodityViewModel,
                                        EmployeeDeleteEWCommodityViewModel employeeDeleteEWCommodityViewModel,
                                        EmployeeGetsEWCommodityViewModel employeeGetsEWCommodityViewModel)
                :base(employeePostEWCommodityViewModel, employeePutEWCommodityViewModel, employeeDeleteEWCommodityViewModel, employeeGetsEWCommodityViewModel)
                    
        {
            _EmployeePostEWCommodityViewModel = employeePostEWCommodityViewModel;
            _EmployeePutEWCommodityViewModel = employeePutEWCommodityViewModel;
            _EmployeeDeleteEWCommodityViewModel = employeeDeleteEWCommodityViewModel;
            _EmployeeGetsEWCommodityViewModel = employeeGetsEWCommodityViewModel;
        }
    }
}