using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofIncomingTag
{
    public class EmployeeIncomingTagPageViewModel : IncomingTagPageViewModel<EmployeeIncomingTag> 
    {
        public readonly EmployeePostIncomingTagViewModel _EmployeePostIncomingTagViewModel;
        public readonly EmployeePutIncomingTagViewModel _EmployeePutIncomingTagViewModel;
        public readonly EmployeeDeleteIncomingTagViewModel _EmployeeDeleteIncomingTagViewModel;
        public readonly EmployeeGetsIncomingTagViewModel _EmployeeGetsIncomingTagViewModel;
        public EmployeeIncomingTagPageViewModel(EmployeePostIncomingTagViewModel employeePostIncomingTagViewModel, 
                                        EmployeePutIncomingTagViewModel employeePutIncomingTagViewModel,
                                        EmployeeDeleteIncomingTagViewModel employeeDeleteIncomingTagViewModel,
                                        EmployeeGetsIncomingTagViewModel employeeGetsIncomingTagViewModel)
                :base(employeePostIncomingTagViewModel, employeePutIncomingTagViewModel, employeeDeleteIncomingTagViewModel, employeeGetsIncomingTagViewModel)
                    
        {
            _EmployeePostIncomingTagViewModel = employeePostIncomingTagViewModel;
            _EmployeePutIncomingTagViewModel = employeePutIncomingTagViewModel;
            _EmployeeDeleteIncomingTagViewModel = employeeDeleteIncomingTagViewModel;
            _EmployeeGetsIncomingTagViewModel = employeeGetsIncomingTagViewModel;
        }
    }
}