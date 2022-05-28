﻿using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofSMCommodity
{
    public class EmployeeSMCommodityPageViewModel : SMCommodityPageViewModel<EmployeeSMCommodity> 
    {
        public readonly EmployeePostSMCommodityViewModel _EmployeePostSMCommodityViewModel;
        public readonly EmployeePutSMCommodityViewModel _EmployeePutSMCommodityViewModel;
        public readonly EmployeeDeleteSMCommodityViewModel _EmployeeDeleteSMCommodityViewModel;
        public readonly EmployeeGetsSMCommodityViewModel _EmployeeGetsSMCommodityViewModel;
        public EmployeeSMCommodityPageViewModel(EmployeePostSMCommodityViewModel employeePostSMCommodityViewModel, 
                                        EmployeePutSMCommodityViewModel employeePutSMCommodityViewModel,
                                        EmployeeDeleteSMCommodityViewModel employeeDeleteSMCommodityViewModel,
                                        EmployeeGetsSMCommodityViewModel employeeGetsSMCommodityViewModel)
                :base(employeePostSMCommodityViewModel, employeePutSMCommodityViewModel, employeeDeleteSMCommodityViewModel, employeeGetsSMCommodityViewModel)
                    
        {
            _EmployeePostSMCommodityViewModel = employeePostSMCommodityViewModel;
            _EmployeePutSMCommodityViewModel = employeePutSMCommodityViewModel;
            _EmployeeDeleteSMCommodityViewModel = employeeDeleteSMCommodityViewModel;
            _EmployeeGetsSMCommodityViewModel = employeeGetsSMCommodityViewModel;
        }
    }
}