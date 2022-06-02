using BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofPlatMarket
{
    public class EmployeePlatMarketPageViewModel : PlatMarketPageViewModel<EmployeePlatMarket> 
    {
        public readonly EmployeePostPlatMarketViewModel _EmployeePostPlatMarketViewModel;
        public readonly EmployeePutPlatMarketViewModel _EmployeePutPlatMarketViewModel;
        public readonly EmployeeDeletePlatMarketViewModel _EmployeeDeletePlatMarketViewModel;
        public readonly EmployeeGetsPlatMarketViewModel _EmployeeGetsPlatMarketViewModel;
        public EmployeePlatMarketPageViewModel(
            EmployeePostPlatMarketViewModel employeePostPlatMarketViewModel, 
                                        EmployeePutPlatMarketViewModel employeePutPlatMarketViewModel,
                                        EmployeeDeletePlatMarketViewModel employeeDeletePlatMarketViewModel,
                                        EmployeeGetsPlatMarketViewModel employeeGetsPlatMarketViewModel)
                :base(employeePostPlatMarketViewModel, employeePutPlatMarketViewModel, employeeDeletePlatMarketViewModel, employeeGetsPlatMarketViewModel)
                    
        {
            _EmployeePostPlatMarketViewModel = employeePostPlatMarketViewModel;
            _EmployeePutPlatMarketViewModel = employeePutPlatMarketViewModel;
            _EmployeeDeletePlatMarketViewModel = employeeDeletePlatMarketViewModel;
            _EmployeeGetsPlatMarketViewModel = employeeGetsPlatMarketViewModel;
        }
    }
}