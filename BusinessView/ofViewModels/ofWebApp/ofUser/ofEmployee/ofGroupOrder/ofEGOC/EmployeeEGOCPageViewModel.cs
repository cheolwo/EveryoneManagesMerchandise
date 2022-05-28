using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofEGOC
{
    public class EmployeeEGOCPageViewModel : EGOCPageViewModel<EmployeeEGOC> 
    {
        public readonly EmployeePostEGOCViewModel _EmployeePostEGOCViewModel;
        public readonly EmployeePutEGOCViewModel _EmployeePutEGOCViewModel;
        public readonly EmployeeDeleteEGOCViewModel _EmployeeDeleteEGOCViewModel;
        public readonly EmployeeGetsEGOCViewModel _EmployeeGetsEGOCViewModel;

        public EmployeeEGOCPageViewModel(EmployeePostEGOCViewModel employeePostEGOCViewModel, 
                                        EmployeePutEGOCViewModel employeePutEGOCViewModel,
                                        EmployeeDeleteEGOCViewModel employeeDeleteEGOCViewModel,
                                        EmployeeGetsEGOCViewModel employeeGetsEGOCViewModel)
                :base(employeePostEGOCViewModel, employeePutEGOCViewModel, employeeDeleteEGOCViewModel, employeeGetsEGOCViewModel)
                    
        {
            _EmployeePostEGOCViewModel = employeePostEGOCViewModel;
            _EmployeePutEGOCViewModel = employeePutEGOCViewModel;
            _EmployeeDeleteEGOCViewModel = employeeDeleteEGOCViewModel;
            _EmployeeGetsEGOCViewModel = employeeGetsEGOCViewModel;
        }
    }
}