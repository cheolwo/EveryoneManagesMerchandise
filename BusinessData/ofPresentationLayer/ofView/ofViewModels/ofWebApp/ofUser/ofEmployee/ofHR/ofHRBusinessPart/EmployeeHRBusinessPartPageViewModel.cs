using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRBusinessPart
{
    public class EmployeeHRBusinessPartPageViewModel : HRBusinessPartPageViewModel<EmployeeHRBusinessPart> 
    {
        public readonly EmployeePostHRBusinessPartViewModel _EmployeePostHRBusinessPartViewModel;
        public readonly EmployeePutHRBusinessPartViewModel _EmployeePutHRBusinessPartViewModel;
        public readonly EmployeeDeleteHRBusinessPartViewModel _EmployeeDeleteHRBusinessPartViewModel;
        public readonly EmployeeGetsHRBusinessPartViewModel _EmployeeGetsHRBusinessPartViewModel;
        public EmployeeHRBusinessPartPageViewModel(EmployeePostHRBusinessPartViewModel employeePostHRBusinessPartViewModel, 
                                        EmployeePutHRBusinessPartViewModel employeePutHRBusinessPartViewModel,
                                        EmployeeDeleteHRBusinessPartViewModel employeeDeleteHRBusinessPartViewModel,
                                        EmployeeGetsHRBusinessPartViewModel employeeGetsHRBusinessPartViewModel)
                :base(employeePostHRBusinessPartViewModel, employeePutHRBusinessPartViewModel, employeeDeleteHRBusinessPartViewModel, employeeGetsHRBusinessPartViewModel)
                    
        {
            _EmployeePostHRBusinessPartViewModel = employeePostHRBusinessPartViewModel;
            _EmployeePutHRBusinessPartViewModel = employeePutHRBusinessPartViewModel;
            _EmployeeDeleteHRBusinessPartViewModel = employeeDeleteHRBusinessPartViewModel;
            _EmployeeGetsHRBusinessPartViewModel = employeeGetsHRBusinessPartViewModel;
        }
    }
}