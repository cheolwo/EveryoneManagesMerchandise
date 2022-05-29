using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class EmployeePostPlatMarketViewModel : PlatMarketPostViewModel<EmployeePlatMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostPlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutPlatMarketViewModel : PlatMarketPutViewModel<EmployeePlatMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutPlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeletePlatMarketViewModel : PlatMarketDeleteViewModel<EmployeePlatMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeletePlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsPlatMarketViewModel : PlatMarketGetsViewModel<EmployeePlatMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsPlatMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}