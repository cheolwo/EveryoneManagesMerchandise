using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofEOCommodity
{
    public class EmployeeEOCommodityPageViewModel : StatusPageViewModel<EmployeeEOCommodity> 
    {
        public readonly EmployeePostEOCommodityViewModel _EmployeePostEOCommodityViewModel;
        public readonly EmployeePutEOCommodityViewModel _EmployeePutEOCommodityViewModel;
        public readonly EmployeeDeleteEOCommodityViewModel _EmployeeDeleteEOCommodityViewModel;
        public readonly EmployeeGetsEOCommodityViewModel _EmployeeGetsEOCommodityViewModel;
        public EmployeeEOCommodityPageViewModel(EmployeePostEOCommodityViewModel employeePostEOCommodityViewModel, 
                                        EmployeePutEOCommodityViewModel employeePutEOCommodityViewModel,
                                        EmployeeDeleteEOCommodityViewModel employeeDeleteEOCommodityViewModel,
                                        EmployeeGetsEOCommodityViewModel employeeGetsEOCommodityViewModel)
                :base(employeePostEOCommodityViewModel, employeePutEOCommodityViewModel, employeeDeleteEOCommodityViewModel, employeeGetsEOCommodityViewModel)
                    
        {
            _EmployeePostEOCommodityViewModel = employeePostEOCommodityViewModel;
            _EmployeePutEOCommodityViewModel = employeePutEOCommodityViewModel;
            _EmployeeDeleteEOCommodityViewModel = employeeDeleteEOCommodityViewModel;
            _EmployeeGetsEOCommodityViewModel = employeeGetsEOCommodityViewModel;
        }
    }
}