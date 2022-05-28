using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofPCommodity
{
    public class EmployeePCommodityPageViewModel : CommodityPageViewModel<EmployeePCommodity> 
    {
        public readonly EmployeePostPCommodityViewModel _EmployeePostPCommodityViewModel;
        public readonly EmployeePutPCommodityViewModel _EmployeePutPCommodityViewModel;
        public readonly EmployeeDeletePCommodityViewModel _EmployeeDeletePCommodityViewModel;
        public readonly EmployeeGetsPCommodityViewModel _EmployeeGetsPCommodityViewModel;
        public EmployeePCommodityPageViewModel(EmployeePostPCommodityViewModel employeePostPCommodityViewModel, 
                                        EmployeePutPCommodityViewModel employeePutPCommodityViewModel,
                                        EmployeeDeletePCommodityViewModel employeeDeletePCommodityViewModel,
                                        EmployeeGetsPCommodityViewModel employeeGetsPCommodityViewModel)
                :base(employeePostPCommodityViewModel, employeePutPCommodityViewModel, employeeDeletePCommodityViewModel, employeeGetsPCommodityViewModel)
                    
        {
            _EmployeePostPCommodityViewModel = employeePostPCommodityViewModel;
            _EmployeePutPCommodityViewModel = employeePutPCommodityViewModel;
            _EmployeeDeletePCommodityViewModel = employeeDeletePCommodityViewModel;
            _EmployeeGetsPCommodityViewModel = employeeGetsPCommodityViewModel;
        }
    }
}