using BusinessLogic.ofExternal.ofSearchingService;
using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofPlatMarket
{
    public class EmployeePlatMarketPageViewModel : CenterPageViewModel<EmployeePlatMarket> 
    {
        public readonly EmployeePostPlatMarketViewModel _EmployeePostPlatMarketViewModel;
        public readonly EmployeePutPlatMarketViewModel _EmployeePutPlatMarketViewModel;
        public readonly EmployeeDeletePlatMarketViewModel _EmployeeDeletePlatMarketViewModel;
        public readonly EmployeeGetsPlatMarketViewModel _EmployeeGetsPlatMarketViewModel;
        public EmployeePlatMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostPlatMarketViewModel employeePostPlatMarketViewModel, 
                                        EmployeePutPlatMarketViewModel employeePutPlatMarketViewModel,
                                        EmployeeDeletePlatMarketViewModel employeeDeletePlatMarketViewModel,
                                        EmployeeGetsPlatMarketViewModel employeeGetsPlatMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostPlatMarketViewModel, employeePutPlatMarketViewModel, employeeDeletePlatMarketViewModel, employeeGetsPlatMarketViewModel)
                    
        {
            _EmployeePostPlatMarketViewModel = employeePostPlatMarketViewModel;
            _EmployeePutPlatMarketViewModel = employeePutPlatMarketViewModel;
            _EmployeeDeletePlatMarketViewModel = employeeDeletePlatMarketViewModel;
            _EmployeeGetsPlatMarketViewModel = employeeGetsPlatMarketViewModel;
        }
    }
}