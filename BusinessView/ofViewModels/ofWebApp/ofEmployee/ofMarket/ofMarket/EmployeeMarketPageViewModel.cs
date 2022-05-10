using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMarket
{
    public class EmployeeMarketPageViewModel : CenterPageViewModel<EmployeeMarket> 
    {
        public EmployeeMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployeePostMarketViewModel employeePostMarketViewModel, 
                                        EmployeePutMarketViewModel employeePutMarketViewModel,
                                        EmployeeDeleteMarketViewModel employeeDeleteMarketViewModel,
                                        EmployeeGetsMarketViewModel employeeGetsMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, employeePostMarketViewModel, employeePutMarketViewModel, employeeDeleteMarketViewModel, employeeGetsMarketViewModel)
                    
        {
            
        }
    }
}