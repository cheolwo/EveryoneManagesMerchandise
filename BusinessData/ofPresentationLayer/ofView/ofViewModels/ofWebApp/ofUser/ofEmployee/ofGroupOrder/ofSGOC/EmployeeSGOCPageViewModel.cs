using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofSGOC
{
    public class EmployeeSGOCPageViewModel : SGOCPageViewModel<EmployeeSGOC> 
    {
        public readonly EmployeePostSGOCViewModel _EmployeePostSGOCViewModel;
        public readonly EmployeePutSGOCViewModel _EmployeePutSGOCViewModel;
        public readonly EmployeeDeleteSGOCViewModel _EmployeeDeleteSGOCViewModel;
        public readonly EmployeeGetsSGOCViewModel _EmployeeGetsSGOCViewModel;
        public EmployeeSGOCPageViewModel(EmployeePostSGOCViewModel employeePostSGOCViewModel, 
                                        EmployeePutSGOCViewModel employeePutSGOCViewModel,
                                        EmployeeDeleteSGOCViewModel employeeDeleteSGOCViewModel,
                                        EmployeeGetsSGOCViewModel employeeGetsSGOCViewModel)
                :base(employeePostSGOCViewModel, employeePutSGOCViewModel, employeeDeleteSGOCViewModel, employeeGetsSGOCViewModel)
                    
        {
            _EmployeePostSGOCViewModel = employeePostSGOCViewModel;
            _EmployeePutSGOCViewModel = employeePutSGOCViewModel;
            _EmployeeDeleteSGOCViewModel = employeeDeleteSGOCViewModel;
            _EmployeeGetsSGOCViewModel = employeeGetsSGOCViewModel;
        }
    }
}