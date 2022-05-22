using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessLogic.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTradeCenter
{
    public class EmployeeTradeCenterPageViewModel : CenterPageViewModel<EmployeeTradeCenter> 
    {
        public readonly EmployeePostTradeCenterViewModel _EmployeePostTradeCenterViewModel;
        public readonly EmployeePutTradeCenterViewModel _EmployeePutTradeCenterViewModel;
        public readonly EmployeeDeleteTradeCenterViewModel _EmployeeDeleteTradeCenterViewModel;
        public readonly EmployeeGetsTradeCenterViewModel _EmployeeGetsTradeCenterViewModel;
        public EmployeeTradeCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostTradeCenterViewModel employeePostTradeCenterViewModel, 
                                        EmployeePutTradeCenterViewModel employeePutTradeCenterViewModel,
                                        EmployeeDeleteTradeCenterViewModel employeeDeleteTradeCenterViewModel,
                                        EmployeeGetsTradeCenterViewModel employeeGetsTradeCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostTradeCenterViewModel, employeePutTradeCenterViewModel, employeeDeleteTradeCenterViewModel, employeeGetsTradeCenterViewModel)
                    
        {
            _EmployeePostTradeCenterViewModel = employeePostTradeCenterViewModel;
            _EmployeePutTradeCenterViewModel = employeePutTradeCenterViewModel;
            _EmployeeDeleteTradeCenterViewModel = employeeDeleteTradeCenterViewModel;
            _EmployeeGetsTradeCenterViewModel = employeeGetsTradeCenterViewModel;
        }
    }
}