﻿using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofSPCommodity
{
    public class EmployeeSPCommodityPageViewModel : StatusPageViewModel<EmployeeSPCommodity> 
    {
        public readonly EmployeePostSPCommodityViewModel _EmployeePostSPCommodityViewModel;
        public readonly EmployeePutSPCommodityViewModel _EmployeePutSPCommodityViewModel;
        public readonly EmployeeDeleteSPCommodityViewModel _EmployeeDeleteSPCommodityViewModel;
        public readonly EmployeeGetsSPCommodityViewModel _EmployeeGetsSPCommodityViewModel;
        public EmployeeSPCommodityPageViewModel(EmployeePostSPCommodityViewModel employeePostSPCommodityViewModel, 
                                        EmployeePutSPCommodityViewModel employeePutSPCommodityViewModel,
                                        EmployeeDeleteSPCommodityViewModel employeeDeleteSPCommodityViewModel,
                                        EmployeeGetsSPCommodityViewModel employeeGetsSPCommodityViewModel)
                :base(employeePostSPCommodityViewModel, employeePutSPCommodityViewModel, employeeDeleteSPCommodityViewModel, employeeGetsSPCommodityViewModel)
                    
        {
            _EmployeePostSPCommodityViewModel = employeePostSPCommodityViewModel;
            _EmployeePutSPCommodityViewModel = employeePutSPCommodityViewModel;
            _EmployeeDeleteSPCommodityViewModel = employeeDeleteSPCommodityViewModel;
            _EmployeeGetsSPCommodityViewModel = employeeGetsSPCommodityViewModel;
        }
    }
}