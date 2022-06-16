using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJCommodity
{
    public class EmployeeJCommodityPageViewModel : JCommodityPageViewModel<EmployeeJCommodity> 
    {
        public readonly EmployeePostJCommodityViewModel _EmployeePostJCommodityViewModel;
        public readonly EmployeePutJCommodityViewModel _EmployeePutJCommodityViewModel;
        public readonly EmployeeDeleteJCommodityViewModel _EmployeeDeleteJCommodityViewModel;
        public readonly EmployeeGetsJCommodityViewModel _EmployeeGetsJCommodityViewModel;
        public EmployeeJCommodityPageViewModel(EmployeePostJCommodityViewModel employeePostJCommodityViewModel, 
                                        EmployeePutJCommodityViewModel employeePutJCommodityViewModel,
                                        EmployeeDeleteJCommodityViewModel employeeDeleteJCommodityViewModel,
                                        EmployeeGetsJCommodityViewModel employeeGetsJCommodityViewModel)
                :base(employeePostJCommodityViewModel, employeePutJCommodityViewModel, employeeDeleteJCommodityViewModel, employeeGetsJCommodityViewModel)
                    
        {
            _EmployeePostJCommodityViewModel = employeePostJCommodityViewModel;
            _EmployeePutJCommodityViewModel = employeePutJCommodityViewModel;
            _EmployeeDeleteJCommodityViewModel = employeeDeleteJCommodityViewModel;
            _EmployeeGetsJCommodityViewModel = employeeGetsJCommodityViewModel;
        }
    }
}