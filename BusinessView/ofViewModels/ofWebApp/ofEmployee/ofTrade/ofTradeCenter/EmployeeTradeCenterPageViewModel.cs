using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTradeCenter
{
    public class EmployeeTradeCenterPageViewModel : CenterPageViewModel<EmployeeTradeCenter> 
    {
        public EmployeeTradeCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostTradeCenterViewModel employeePostTradeCenterViewModel, 
                                        EmployeePutTradeCenterViewModel employeePutTradeCenterViewModel,
                                        EmployeeDeleteTradeCenterViewModel employeeDeleteTradeCenterViewModel,
                                        EmployeeGetsTradeCenterViewModel employeeGetsTradeCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostTradeCenterViewModel, employeePutTradeCenterViewModel, employeeDeleteTradeCenterViewModel, employeeGetsTradeCenterViewModel)
                    
        {
            
        }
    }
}