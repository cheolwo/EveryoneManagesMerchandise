﻿using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofMTCommodity
{
    public class EmployeeMTCommodityPageViewModel : StatusPageViewModel<EmployeeMTCommodity> 
    {
        public readonly EmployeePostMTCommodityViewModel _EmployeePostMTCommodityViewModel;
        public readonly EmployeePutMTCommodityViewModel _EmployeePutMTCommodityViewModel;
        public readonly EmployeeDeleteMTCommodityViewModel _EmployeeDeleteMTCommodityViewModel;
        public readonly EmployeeGetsMTCommodityViewModel _EmployeeGetsMTCommodityViewModel;
        public EmployeeMTCommodityPageViewModel(EmployeePostMTCommodityViewModel employeePostMTCommodityViewModel, 
                                        EmployeePutMTCommodityViewModel employeePutMTCommodityViewModel,
                                        EmployeeDeleteMTCommodityViewModel employeeDeleteMTCommodityViewModel,
                                        EmployeeGetsMTCommodityViewModel employeeGetsMTCommodityViewModel)
                :base(employeePostMTCommodityViewModel, employeePutMTCommodityViewModel, employeeDeleteMTCommodityViewModel, employeeGetsMTCommodityViewModel)
                    
        {
            _EmployeePostMTCommodityViewModel = employeePostMTCommodityViewModel;
            _EmployeePutMTCommodityViewModel = employeePutMTCommodityViewModel;
            _EmployeeDeleteMTCommodityViewModel = employeeDeleteMTCommodityViewModel;
            _EmployeeGetsMTCommodityViewModel = employeeGetsMTCommodityViewModel;
        }
    }
}