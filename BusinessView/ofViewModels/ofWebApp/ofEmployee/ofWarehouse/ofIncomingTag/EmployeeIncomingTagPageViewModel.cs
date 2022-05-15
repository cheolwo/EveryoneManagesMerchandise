using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofIncomingTag
{
    public class EmployeeIncomingTagPageViewModel : EntityPageViewModel<EmployeeIncomingTag> 
    {
        public readonly EmployeePostIncmoingTagViewModel _EmployeePostIncmoingTagViewModel;
        public readonly EmployeePutIncmoingTagViewModel _EmployeePutIncmoingTagViewModel;
        public readonly EmployeeDeleteIncmoingTagViewModel _EmployeeDeleteIncmoingTagViewModel;
        public readonly EmployeeGetsIncmoingTagViewModel _EmployeeGetsIncmoingTagViewModel;
        public EmployeeIncomingTagPageViewModel(EmployeePostIncomingTagViewModel employeePostIncomingTagViewModel, 
                                        EmployeePutIncomingTagViewModel employeePutIncomingTagViewModel,
                                        EmployeeDeleteIncomingTagViewModel employeeDeleteIncomingTagViewModel,
                                        EmployeeGetsIncomingTagViewModel employeeGetsIncomingTagViewModel)
                :base(employeePostIncomingTagViewModel, employeePutIncomingTagViewModel, employeeDeleteIncomingTagViewModel, employeeGetsIncomingTagViewModel)
                    
        {
            _EmployeePostIncmoingTagViewModel = employeePostIncmoingTagViewModel;
            _EmployeePutIncmoingTagViewModel = employeePutIncmoingTagViewModel;
            _EmployeeDeleteIncmoingTagViewModel = employeeDeleteIncmoingTagViewModel;
            _EmployeeGetsIncmoingTagViewModel = employeeGetsIncmoingTagViewModel;
        }
    }
}