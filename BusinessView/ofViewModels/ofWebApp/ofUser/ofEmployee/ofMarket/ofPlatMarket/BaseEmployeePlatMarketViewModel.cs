using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class BaseEmployeePlatMarketViewModel : BaseCenterViewModel<EmployeePlatMarket>
    {
        public BaseEmployeePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostPlatMarketViewModel : CenterPostViewModel<EmployeePlatMarket>
    {
        public EmployeePostPlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutPlatMarketViewModel : CenterPutViewModel<EmployeePlatMarket>
    {
        public EmployeePutPlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeletePlatMarketViewModel : CenterDeleteViewModel<EmployeePlatMarket>
    {
        public EmployeeDeletePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsPlatMarketViewModel : CenterGetsViewModel<EmployeePlatMarket>
    {
        public EmployeeGetsPlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
