using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerTradeCenterViewModel : BaseCenterViewModel<EmployerTradeCenter>
    {
        public BaseEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostTradeCenterViewModel : EmployerCenterPostViewModel<EmployerTradeCenter>
    {
        public EmployerPostTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutTradeCenterViewModel : EmployerCenterPutViewModel<EmployerTradeCenter>
    {
        public EmployerPutTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteTradeCenterViewModel : EmployerCenterDeleteViewModel<EmployerTradeCenter>
    {
        public EmployerDeleteTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsTradeCenterViewModel : EmployerCenterGetsViewModel<EmployerTradeCenter>
    {
        public EmployerGetsTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
