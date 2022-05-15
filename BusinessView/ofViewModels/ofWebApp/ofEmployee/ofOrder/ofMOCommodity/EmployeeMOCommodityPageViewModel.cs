using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofMOCommodity
{
    public class EmployeeMOCommodityPageViewModel : StatusPageViewModel<EmployeeMOCommodity> 
    {
        public readonly EmployeePostMOCommodityViewModel _EmployeePostMOCommodityViewModel;
        public readonly EmployeePutMOCommodityViewModel _EmployeePutMOCommodityViewModel;
        public readonly EmployeeDeleteMOCommodityViewModel _EmployeeDeleteMOCommodityViewModel;
        public readonly EmployeeGetsMOCommodityViewModel _EmployeeGetsMOCommodityViewModel;
        public EmployeeMOCommodityPageViewModel(EmployeePostMOCommodityViewModel employeePostMOCommodityViewModel, 
                                        EmployeePutMOCommodityViewModel employeePutMOCommodityViewModel,
                                        EmployeeDeleteMOCommodityViewModel employeeDeleteMOCommodityViewModel,
                                        EmployeeGetsMOCommodityViewModel employeeGetsMOCommodityViewModel)
                :base(employeePostMOCommodityViewModel, employeePutMOCommodityViewModel, employeeDeleteMOCommodityViewModel, employeeGetsMOCommodityViewModel)
                    
        {
            _EmployeePostMOCommodityViewModel = employeePostMOCommodityViewModel;
            _EmployeePutMOCommodityViewModel = employeePutMOCommodityViewModel;
            _EmployeeDeleteMOCommodityViewModel = employeeDeleteMOCommodityViewModel;
            _EmployeeGetsMOCommodityViewModel = employeeGetsMOCommodityViewModel;
        }
    }
}