using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMarket
{
    public class EmployeeMarketPageViewModel : MarketPageViewModel<EmployeeMarket> 
    {
        public readonly EmployeePostMarketViewModel _EmployeePostMarketViewModel;
        public readonly EmployeePutMarketViewModel _EmployeePutMarketViewModel;
        public readonly EmployeeDeleteMarketViewModel _EmployeeDeleteMarketViewModel;
        public readonly EmployeeGetsMarketViewModel _EmployeeGetsMarketViewModel;
        public EmployeeMarketPageViewModel(
            EmployeePostMarketViewModel employeePostMarketViewModel, 
                                        EmployeePutMarketViewModel employeePutMarketViewModel,
                                        EmployeeDeleteMarketViewModel employeeDeleteMarketViewModel,
                                        EmployeeGetsMarketViewModel employeeGetsMarketViewModel)
                :base( employeePostMarketViewModel, employeePutMarketViewModel, employeeDeleteMarketViewModel, employeeGetsMarketViewModel)
                    
        {
            _EmployeePostMarketViewModel = employeePostMarketViewModel;
            _EmployeePutMarketViewModel = employeePutMarketViewModel;
            _EmployeeDeleteMarketViewModel = employeeDeleteMarketViewModel;
            _EmployeeGetsMarketViewModel = employeeGetsMarketViewModel;
        }
    }
}