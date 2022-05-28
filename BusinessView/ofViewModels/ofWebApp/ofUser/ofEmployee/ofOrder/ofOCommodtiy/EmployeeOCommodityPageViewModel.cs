using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofOCommodity
{
    public class EmployeeOCommodityPageViewModel : CommodityPageViewModel<EmployeeOCommodity> 
    {
        public readonly EmployeePostOCommodityViewModel _EmployeePostOCommodityViewModel;
        public readonly EmployeePutOCommodityViewModel _EmployeePutOCommodityViewModel;
        public readonly EmployeeDeleteOCommodityViewModel _EmployeeDeleteOCommodityViewModel;
        public readonly EmployeeGetsOCommodityViewModel _EmployeeGetsOCommodityViewModel;
        public EmployeeOCommodityPageViewModel(EmployeePostOCommodityViewModel employeePostOCommodityViewModel, 
                                        EmployeePutOCommodityViewModel employeePutOCommodityViewModel,
                                        EmployeeDeleteOCommodityViewModel employeeDeleteOCommodityViewModel,
                                        EmployeeGetsOCommodityViewModel employeeGetsOCommodityViewModel)
                :base(employeePostOCommodityViewModel, employeePutOCommodityViewModel, employeeDeleteOCommodityViewModel, employeeGetsOCommodityViewModel)
                    
        {
            _EmployeePostOCommodityViewModel = employeePostOCommodityViewModel;
            _EmployeePutOCommodityViewModel = employeePutOCommodityViewModel;
            _EmployeeDeleteOCommodityViewModel = employeeDeleteOCommodityViewModel;
            _EmployeeGetsOCommodityViewModel = employeeGetsOCommodityViewModel;
        }
    }
}