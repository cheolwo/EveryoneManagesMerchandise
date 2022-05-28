using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMarket
{
    public class EmployeeMarketPageViewModel : MarketPageViewModel<EmployeeMarket> 
    {
        public readonly EmployeePostMarketViewModel _EmployeePostMarketViewModel;
        public readonly EmployeePutMarketViewModel _EmployeePutMarketViewModel;
        public readonly EmployeeDeleteMarketViewModel _EmployeeDeleteMarketViewModel;
        public readonly EmployeeGetsMarketViewModel _EmployeeGetsMarketViewModel;
        public EmployeeMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostMarketViewModel employeePostMarketViewModel, 
                                        EmployeePutMarketViewModel employeePutMarketViewModel,
                                        EmployeeDeleteMarketViewModel employeeDeleteMarketViewModel,
                                        EmployeeGetsMarketViewModel employeeGetsMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostMarketViewModel, employeePutMarketViewModel, employeeDeleteMarketViewModel, employeeGetsMarketViewModel)
                    
        {
            _EmployeePostMarketViewModel = employeePostMarketViewModel;
            _EmployeePutMarketViewModel = employeePutMarketViewModel;
            _EmployeeDeleteMarketViewModel = employeeDeleteMarketViewModel;
            _EmployeeGetsMarketViewModel = employeeGetsMarketViewModel;
        }
    }
}