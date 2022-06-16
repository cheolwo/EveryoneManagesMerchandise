using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofMPCommodity
{
    public class EmployeeMPCommodityPageViewModel : MPCommodityPageViewModel<EmployeeMPCommodity> 
    {
        public readonly EmployeePostMPCommodityViewModel _EmployeePostMPCommodityViewModel;
        public readonly EmployeePutMPCommodityViewModel _EmployeePutMPCommodityViewModel;
        public readonly EmployeeDeleteMPCommodityViewModel _EmployeeDeleteMPCommodityViewModel;
        public readonly EmployeeGetsMPCommodityViewModel _EmployeeGetsMPCommodityViewModel;
        public EmployeeMPCommodityPageViewModel(EmployeePostMPCommodityViewModel employeePostMPCommodityViewModel, 
                                        EmployeePutMPCommodityViewModel employeePutMPCommodityViewModel,
                                        EmployeeDeleteMPCommodityViewModel employeeDeleteMPCommodityViewModel,
                                        EmployeeGetsMPCommodityViewModel employeeGetsMPCommodityViewModel)
                :base(employeePostMPCommodityViewModel, employeePutMPCommodityViewModel, employeeDeleteMPCommodityViewModel, employeeGetsMPCommodityViewModel)
                    
        {
            _EmployeePostMPCommodityViewModel = employeePostMPCommodityViewModel;
            _EmployeePutMPCommodityViewModel = employeePutMPCommodityViewModel;
            _EmployeeDeleteMPCommodityViewModel = employeeDeleteMPCommodityViewModel;
            _EmployeeGetsMPCommodityViewModel = employeeGetsMPCommodityViewModel;
        }
    }
}