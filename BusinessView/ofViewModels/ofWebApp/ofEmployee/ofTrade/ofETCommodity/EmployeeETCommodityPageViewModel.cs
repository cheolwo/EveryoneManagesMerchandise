﻿using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofETCommodity
{
    public class EmployeeETCommodityPageViewModel : StatusPageViewModel<EmployeeETCommodity> 
    {
        public readonly EmployeePostETCommodityViewModel _EmployeePostETCommodityViewModel;
        public readonly EmployeePutETCommodityViewModel _EmployeePutETCommodityViewModel;
        public readonly EmployeeDeleteETCommodityViewModel _EmployeeDeleteETCommodityViewModel;
        public readonly EmployeeGetsETCommodityViewModel _EmployeeGetsETCommodityViewModel;
        public EmployeeETCommodityPageViewModel(EmployeePostETCommodityViewModel employeePostETCommodityViewModel, 
                                        EmployeePutETCommodityViewModel employeePutETCommodityViewModel,
                                        EmployeeDeleteETCommodityViewModel employeeDeleteETCommodityViewModel,
                                        EmployeeGetsETCommodityViewModel employeeGetsETCommodityViewModel)
                :base(employeePostETCommodityViewModel, employeePutETCommodityViewModel, employeeDeleteETCommodityViewModel, employeeGetsETCommodityViewModel)
                    
        {
            _EmployeePostETCommodityViewModel = employeePostETCommodityViewModel;
            _EmployeePutETCommodityViewModel = employeePutETCommodityViewModel;
            _EmployeeDeleteETCommodityViewModel = employeeDeleteETCommodityViewModel;
            _EmployeeGetsETCommodityViewModel = employeeGetsETCommodityViewModel;
        }
    }
}