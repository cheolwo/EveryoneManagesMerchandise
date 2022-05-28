using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class EmployeePostTradeCenterViewModel : TradeCenterPostViewModel<EmployeeTradeCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutTradeCenterViewModel : TradeCenterPutViewModel<EmployeeTradeCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteTradeCenterViewModel : TradeCenterDeleteViewModel<EmployeeTradeCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsTradeCenterViewModel : TradeCenterGetsViewModel<EmployeeTradeCenter>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
