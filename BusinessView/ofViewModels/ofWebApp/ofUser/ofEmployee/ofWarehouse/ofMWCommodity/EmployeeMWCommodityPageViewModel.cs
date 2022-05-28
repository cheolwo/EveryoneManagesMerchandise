using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofMWCommodity
{
    public class EmployeeMWCommodityPageViewModel : MWCommodityPageViewModel<EmployeeMWCommodity> 
    {
        public readonly EmployeePostMWCommodityViewModel _EmployeePostMWCommodityViewModel;
        public readonly EmployeePutMWCommodityViewModel _EmployeePutMWCommodityViewModel;
        public readonly EmployeeDeleteMWCommodityViewModel _EmployeeDeleteMWCommodityViewModel;
        public readonly EmployeeGetsMWCommodityViewModel _EmployeeGetsMWCommodityViewModel;
        public EmployeeMWCommodityPageViewModel(EmployeePostMWCommodityViewModel employeePostMWCommodityViewModel, 
                                        EmployeePutMWCommodityViewModel employeePutMWCommodityViewModel,
                                        EmployeeDeleteMWCommodityViewModel employeeDeleteMWCommodityViewModel,
                                        EmployeeGetsMWCommodityViewModel employeeGetsMWCommodityViewModel)
                :base(employeePostMWCommodityViewModel, employeePutMWCommodityViewModel, employeeDeleteMWCommodityViewModel, employeeGetsMWCommodityViewModel)
                    
        {
            _EmployeePostMWCommodityViewModel = employeePostMWCommodityViewModel;
            _EmployeePutMWCommodityViewModel = employeePutMWCommodityViewModel;
            _EmployeeDeleteMWCommodityViewModel = employeeDeleteMWCommodityViewModel;
            _EmployeeGetsMWCommodityViewModel = employeeGetsMWCommodityViewModel;
        }
    }
}