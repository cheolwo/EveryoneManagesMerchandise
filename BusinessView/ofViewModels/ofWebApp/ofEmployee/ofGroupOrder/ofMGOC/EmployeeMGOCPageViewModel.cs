using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofMGOC
{
    public class EmployeeMGOCPageViewModel : StatusPageViewModel<EmployeeMGOC> 
    {
        public readonly EmployeePostMGOCViewModel _EmployeePostMGOCViewModel;
        public readonly EmployeePutMGOCViewModel _EmployeePutMGOCViewModel;
        public readonly EmployeeDeleteMGOCViewModel _EmployeeDeleteMGOCViewModel;
        public readonly EmployeeGetsMGOCViewModel _EmployeeGetsMGOCViewModel;
        public EmployeeMGOCPageViewModel(EmployeePostMGOCViewModel employeePostMGOCViewModel, 
                                        EmployeePutMGOCViewModel employeePutMGOCViewModel,
                                        EmployeeDeleteMGOCViewModel employeeDeleteMGOCViewModel,
                                        EmployeeGetsMGOCViewModel employeeGetsMGOCViewModel)
                :base(employeePostMGOCViewModel, employeePutMGOCViewModel, employeeDeleteMGOCViewModel, employeeGetsMGOCViewModel)
                    
        {
            _EmployeePostMGOCViewModel = employeePostMGOCViewModel;
            _EmployeePutMGOCViewModel = employeePutMGOCViewModel;
            _EmployeeDeleteMGOCViewModel = employeeDeleteMGOCViewModel;
            _EmployeeGetsMGOCViewModel = employeeGetsMGOCViewModel;
        }
    }
}