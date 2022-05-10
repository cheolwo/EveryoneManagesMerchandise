using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeTradeCenterViewModel : BaseCenterViewModel<EmployeeTradeCenter>
    {
        public BaseEmployeeTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostTradeCenterViewModel : CenterPostViewModel<EmployeeTradeCenter>
    {
        public EmployeePostTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutTradeCenterViewModel : CenterPutViewModel<EmployeeTradeCenter>
    {
        public EmployeePutTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteTradeCenterViewModel : CenterDeleteViewModel<EmployeeTradeCenter>
    {
        public EmployeeDeleteTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsTradeCenterViewModel : CenterGetsViewModel<EmployeeTradeCenter>
    {
        public EmployeeGetsTradeCenterViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
