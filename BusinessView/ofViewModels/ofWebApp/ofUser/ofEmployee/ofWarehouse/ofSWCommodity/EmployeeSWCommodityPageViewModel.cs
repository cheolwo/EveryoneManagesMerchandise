using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofSWCommodity
{
    public class EmployeeSWCommodityPageViewModel : SWCommodityPageViewModel<EmployeeSWCommodity> 
    {
        public readonly EmployeePostSWCommodityViewModel _EmployeePostSWCommodityViewModel;
        public readonly EmployeePutSWCommodityViewModel _EmployeePutSWCommodityViewModel;
        public readonly EmployeeDeleteSWCommodityViewModel _EmployeeDeleteSWCommodityViewModel;
        public readonly EmployeeGetsSWCommodityViewModel _EmployeeGetsSWCommodityViewModel;
        public EmployeeSWCommodityPageViewModel(EmployeePostSWCommodityViewModel employeePostSWCommodityViewModel, 
                                        EmployeePutSWCommodityViewModel employeePutSWCommodityViewModel,
                                        EmployeeDeleteSWCommodityViewModel employeeDeleteSWCommodityViewModel,
                                        EmployeeGetsSWCommodityViewModel employeeGetsSWCommodityViewModel)
                :base(employeePostSWCommodityViewModel, employeePutSWCommodityViewModel, employeeDeleteSWCommodityViewModel, employeeGetsSWCommodityViewModel)
                    
        {
            _EmployeePostSWCommodityViewModel = employeePostSWCommodityViewModel;
            _EmployeePutSWCommodityViewModel = employeePutSWCommodityViewModel;
            _EmployeeDeleteSWCommodityViewModel = employeeDeleteSWCommodityViewModel;
            _EmployeeGetsSWCommodityViewModel = employeeGetsSWCommodityViewModel;
        }
    }
}