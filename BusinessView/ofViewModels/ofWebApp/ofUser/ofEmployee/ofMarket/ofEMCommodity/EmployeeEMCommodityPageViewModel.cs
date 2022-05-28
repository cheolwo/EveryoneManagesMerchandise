using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofEMCommodity
{
    public class EmployeeEMCommodityPageViewModel : EMCommodityPageViewModel<EmployeeEMCommodity> 
    {
        public readonly EmployeePostEMCommodityViewModel _EmployeePostEMCommodityViewModel;
        public readonly EmployeePutEMCommodityViewModel _EmployeePutEMCommodityViewModel;
        public readonly EmployeeDeleteEMCommodityViewModel _EmployeeDeleteEMCommodityViewModel;
        public readonly EmployeeGetsEMCommodityViewModel _EmployeeGetsEMCommodityViewModel;
        public EmployeeEMCommodityPageViewModel(EmployeePostEMCommodityViewModel employeePostEMCommodityViewModel, 
                                        EmployeePutEMCommodityViewModel employeePutEMCommodityViewModel,
                                        EmployeeDeleteEMCommodityViewModel employeeDeleteEMCommodityViewModel,
                                        EmployeeGetsEMCommodityViewModel employeeGetsEMCommodityViewModel)
                :base(employeePostEMCommodityViewModel, employeePutEMCommodityViewModel, employeeDeleteEMCommodityViewModel, employeeGetsEMCommodityViewModel)
                    
        {
            _EmployeePostEMCommodityViewModel = employeePostEMCommodityViewModel;
            _EmployeePutEMCommodityViewModel = employeePutEMCommodityViewModel;
            _EmployeeDeleteEMCommodityViewModel = employeeDeleteEMCommodityViewModel;
            _EmployeeGetsEMCommodityViewModel = employeeGetsEMCommodityViewModel;
        }
    }
}