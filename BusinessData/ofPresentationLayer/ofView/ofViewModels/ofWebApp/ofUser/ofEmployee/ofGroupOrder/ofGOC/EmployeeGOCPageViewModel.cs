using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
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