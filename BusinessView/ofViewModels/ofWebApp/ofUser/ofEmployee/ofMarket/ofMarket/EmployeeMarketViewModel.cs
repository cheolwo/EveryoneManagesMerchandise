using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket
{
    public class EmployeePostMarketViewModel : MarketPostViewModel<EmployeeMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostMarketViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutMarketViewModel : MarketPutViewModel<EmployeeMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteMarketViewModel : MarketDeleteViewModel<EmployeeMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsMarketViewModel : MarketGetsViewModel<EmployeeMarket>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsMarketViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
