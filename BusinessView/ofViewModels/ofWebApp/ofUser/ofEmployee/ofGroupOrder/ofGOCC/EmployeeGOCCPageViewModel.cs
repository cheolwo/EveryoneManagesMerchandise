using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOCC
{
    public class EmployeeGOCCPageViewModel : GOCCPageViewModel<EmployeeGOCC> 
    {
        public readonly EmployeePostGOCCViewModel _EmployeePostGOCCViewModel;
        public readonly EmployeePutGOCCViewModel _EmployeePutGOCCViewModel;
        public readonly EmployeeDeleteGOCCViewModel _EmployeeDeleteGOCCViewModel;
        public readonly EmployeeGetsGOCCViewModel _EmployeeGetsGOCCViewModel;
        public EmployeeGOCCPageViewModel(EmployeePostGOCCViewModel employeePostGOCCViewModel, 
                                        EmployeePutGOCCViewModel employeePutGOCCViewModel,
                                        EmployeeDeleteGOCCViewModel employeeDeleteGOCCViewModel,
                                        EmployeeGetsGOCCViewModel employeeGetsGOCCViewModel)
                :base(employeePostGOCCViewModel, employeePutGOCCViewModel, employeeDeleteGOCCViewModel, employeeGetsGOCCViewModel)
                    
        {
            _EmployeePostGOCCViewModel = employeePostGOCCViewModel;
            _EmployeePutGOCCViewModel = employeePutGOCCViewModel;
            _EmployeeDeleteGOCCViewModel = employeeDeleteGOCCViewModel;
            _EmployeeGetsGOCCViewModel = employeeGetsGOCCViewModel;
        }
    }
}