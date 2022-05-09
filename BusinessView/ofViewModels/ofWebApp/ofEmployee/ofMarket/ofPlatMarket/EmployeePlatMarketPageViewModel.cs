using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofPlatMarket
{
    public class EmployeePlatMarketPageViewModel : CenterPageViewModel<EmployeePlatMarket> 
    {
        public EmployeePlatMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostPlatMarketViewModel employeePostPlatMarketViewModel, 
                                        EmployeePutPlatMarketViewModel employeePutPlatMarketViewModel,
                                        EmployeeDeletePlatMarketViewModel employeeDeletePlatMarketViewModel,
                                        EmployeeGetsPlatMarketViewModel employeeGetsPlatMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostPlatMarketViewModel, employeePutPlatMarketViewModel, employeeDeletePlatMarketViewModel, employeeGetsPlatMarketViewModel)
                    
        {
            
        }
    }
}