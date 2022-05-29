﻿using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofOrderCenter
{
    public class EmployeeOrderCenterPageViewModel : OrderCenterPageViewModel<EmployeeOrderCenter> 
    {
        public readonly EmployeePostOrderCenterViewModel _EmployeePostOrderCenterViewModel;
        public readonly EmployeePutOrderCenterViewModel _EmployeePutOrderCenterViewModel;
        public readonly EmployeeDeleteOrderCenterViewModel _EmployeeDeleteOrderCenterViewModel;
        public readonly EmployeeGetsOrderCenterViewModel _EmployeeGetsOrderCenterViewModel;
        public EmployeeOrderCenterPageViewModel(
            EmployeePostOrderCenterViewModel employeePostOrderCenterViewModel, 
                                        EmployeePutOrderCenterViewModel employeePutOrderCenterViewModel,
                                        EmployeeDeleteOrderCenterViewModel employeeDeleteOrderCenterViewModel,
                                        EmployeeGetsOrderCenterViewModel employeeGetsOrderCenterViewModel)
                :base(employeePostOrderCenterViewModel, employeePutOrderCenterViewModel, employeeDeleteOrderCenterViewModel, employeeGetsOrderCenterViewModel)
                    
        {
            _EmployeePostOrderCenterViewModel = employeePostOrderCenterViewModel;
            _EmployeePutOrderCenterViewModel = employeePutOrderCenterViewModel;
            _EmployeeDeleteOrderCenterViewModel = employeeDeleteOrderCenterViewModel;
            _EmployeeGetsOrderCenterViewModel = employeeGetsOrderCenterViewModel;
        }
    }
}