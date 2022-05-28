using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMCommodity
{
    public class EmployeeMCommodityPageViewModel : MCommodityPageViewModel<EmployeeMCommodity> 
    {
        public readonly EmployeePostMCommodityViewModel _EmployeePostMCommodityViewModel;
        public readonly EmployeePutMCommodityViewModel _EmployeePutMCommodityViewModel;
        public readonly EmployeeDeleteMCommodityViewModel _EmployeeDeleteMCommodityViewModel;
        public readonly EmployeeGetsMCommodityViewModel _EmployeeGetsMCommodityViewModel;
        public EmployeeMCommodityPageViewModel(EmployeePostMCommodityViewModel employeePostMCommodityViewModel, 
                                        EmployeePutMCommodityViewModel employeePutMCommodityViewModel,
                                        EmployeeDeleteMCommodityViewModel employeeDeleteMCommodityViewModel,
                                        EmployeeGetsMCommodityViewModel employeeGetsMCommodityViewModel)
                :base(employeePostMCommodityViewModel, employeePutMCommodityViewModel, employeeDeleteMCommodityViewModel, employeeGetsMCommodityViewModel)
                    
        {
             _EmployeePostMCommodityViewModel = employeePostMCommodityViewModel;
            _EmployeePutMCommodityViewModel = employeePutMCommodityViewModel;
            _EmployeeDeleteMCommodityViewModel = employeeDeleteMCommodityViewModel;
            _EmployeeGetsMCommodityViewModel = employeeGetsMCommodityViewModel;
        }
    }
}