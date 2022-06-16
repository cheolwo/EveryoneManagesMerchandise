using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWCommodity
{
    public class EmployeeWCommodityPageViewModel : WCommodityPageViewModel<EmployeeWCommodity> 
    {
        public readonly EmployeePostWCommodityViewModel _EmployeePostWCommodityViewModel;
        public readonly EmployeePutWCommodityViewModel _EmployeePutWCommodityViewModel;
        public readonly EmployeeDeleteWCommodityViewModel _EmployeeDeleteWCommodityViewModel;
        public readonly EmployeeGetsWCommodityViewModel _EmployeeGetsWCommodityViewModel;
        public EmployeeWCommodityPageViewModel(EmployeePostWCommodityViewModel employeePostWCommodityViewModel, 
                                        EmployeePutWCommodityViewModel employeePutWCommodityViewModel,
                                        EmployeeDeleteWCommodityViewModel employeeDeleteWCommodityViewModel,
                                        EmployeeGetsWCommodityViewModel employeeGetsWCommodityViewModel)
                :base(employeePostWCommodityViewModel, employeePutWCommodityViewModel, employeeDeleteWCommodityViewModel, employeeGetsWCommodityViewModel)
                    
        {
            _EmployeePostWCommodityViewModel = employeePostWCommodityViewModel;
            _EmployeePutWCommodityViewModel = employeePutWCommodityViewModel;
            _EmployeeDeleteWCommodityViewModel = employeeDeleteWCommodityViewModel;
            _EmployeeGetsWCommodityViewModel = employeeGetsWCommodityViewModel;
        }
    }
}