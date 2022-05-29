﻿using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOC
{
    public class EmployeeGOCPageViewModel : GOCPageViewModel<EmployeeGOC> 
    {
        public readonly EmployeePostGOCViewModel _EmployeePostGOCViewModel;
        public readonly EmployeePutGOCViewModel _EmployeePutGOCViewModel;
        public readonly EmployeeDeleteGOCViewModel _EmployeeDeleteGOCViewModel;
        public readonly EmployeeGetsGOCViewModel _EmployeeGetsGOCViewModel;

        public EmployeeGOCPageViewModel(
                                        EmployeePostGOCViewModel employeePostGOCViewModel, 
                                        EmployeePutGOCViewModel employeePutGOCViewModel,
                                        EmployeeDeleteGOCViewModel employeeDeleteGOCViewModel,
                                        EmployeeGetsGOCViewModel employeeGetsGOCViewModel)
                :base(employeePostGOCViewModel, employeePutGOCViewModel, employeeDeleteGOCViewModel, employeeGetsGOCViewModel)
                    
        {
            _EmployeePostGOCViewModel = employeePostGOCViewModel;
            _EmployeePutGOCViewModel = employeePutGOCViewModel;
            _EmployeeDeleteGOCViewModel = employeeDeleteGOCViewModel;
            _EmployeeGetsGOCViewModel = employeeGetsGOCViewModel;
        }
    }
}