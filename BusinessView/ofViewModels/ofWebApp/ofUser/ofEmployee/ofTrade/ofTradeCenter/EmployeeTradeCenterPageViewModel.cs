using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTradeCenter
{
    public class EmployeeTradeCenterPageViewModel : TradeCenterPageViewModel<EmployeeTradeCenter> 
    {
        public readonly EmployeePostTradeCenterViewModel _EmployeePostTradeCenterViewModel;
        public readonly EmployeePutTradeCenterViewModel _EmployeePutTradeCenterViewModel;
        public readonly EmployeeDeleteTradeCenterViewModel _EmployeeDeleteTradeCenterViewModel;
        public readonly EmployeeGetsTradeCenterViewModel _EmployeeGetsTradeCenterViewModel;
        public EmployeeTradeCenterPageViewModel(
            EmployeePostTradeCenterViewModel employeePostTradeCenterViewModel, 
                                        EmployeePutTradeCenterViewModel employeePutTradeCenterViewModel,
                                        EmployeeDeleteTradeCenterViewModel employeeDeleteTradeCenterViewModel,
                                        EmployeeGetsTradeCenterViewModel employeeGetsTradeCenterViewModel)
                :base(employeePostTradeCenterViewModel, employeePutTradeCenterViewModel, employeeDeleteTradeCenterViewModel, employeeGetsTradeCenterViewModel)
                    
        {
            _EmployeePostTradeCenterViewModel = employeePostTradeCenterViewModel;
            _EmployeePutTradeCenterViewModel = employeePutTradeCenterViewModel;
            _EmployeeDeleteTradeCenterViewModel = employeeDeleteTradeCenterViewModel;
            _EmployeeGetsTradeCenterViewModel = employeeGetsTradeCenterViewModel;
        }
    }
}