using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofEPCommodity
{
    public class EmployeeEPCommodityPageViewModel : StatusPageViewModel<EmployeeEPCommodity> 
    {
        public readonly EmployeePostEPCommodityViewModel _EmployeePostEPCommodityViewModel;
        public readonly EmployeePutEPCommodityViewModel _EmployeePutEPCommodityViewModel;
        public readonly EmployeeDeleteEPCommodityViewModel _EmployeeDeleteEPCommodityViewModel;
        public readonly EmployeeGetsEPCommodityViewModel _EmployeeGetsEPCommodityViewModel;
        public EmployeeEPCommodityPageViewModel(EmployeePostEPCommodityViewModel employeePostEPCommodityViewModel, 
                                        EmployeePutEPCommodityViewModel employeePutEPCommodityViewModel,
                                        EmployeeDeleteEPCommodityViewModel employeeDeleteEPCommodityViewModel,
                                        EmployeeGetsEPCommodityViewModel employeeGetsEPCommodityViewModel)
                :base(employeePostEPCommodityViewModel, employeePutEPCommodityViewModel, employeeDeleteEPCommodityViewModel, employeeGetsEPCommodityViewModel)
                    
        {
            _EmployeePostEPCommodityViewModel = employeePostEPCommodityViewModel;
            _EmployeePutEPCommodityViewModel = employeePutEPCommodityViewModel;
            _EmployeeDeleteEPCommodityViewModel = employeeDeleteEPCommodityViewModel;
            _EmployeeGetsEPCommodityViewModel = employeeGetsEPCommodityViewModel;
        }
    }
}