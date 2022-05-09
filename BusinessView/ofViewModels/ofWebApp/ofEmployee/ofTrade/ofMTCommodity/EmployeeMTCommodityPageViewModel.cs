using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofMTCommodity
{
    public class EmployeeMTCommodityPageViewModel : StatusPageViewModel<EmployeeMTCommodity> 
    {
        public EmployeeMTCommodityPageViewModel(EmployeePostMTCommodityViewModel employeePostMTCommodityViewModel, 
                                        EmployeePutMTCommodityViewModel employeePutMTCommodityViewModel,
                                        EmployeeDeleteMTCommodityViewModel employeeDeleteMTCommodityViewModel,
                                        EmployeeGetsMTCommodityViewModel employeeGetsMTCommodityViewModel)
                :base(employeePostMTCommodityViewModel, employeePutMTCommodityViewModel, employeeDeleteMTCommodityViewModel, employeeGetsMTCommodityViewModel)
                    
        {
            
        }
    }
}