using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerTradeCenterViewModel : BaseCenterViewModel<EmployerTradeCenter>
    {
        public BaseEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostTradeCenterViewModel : CenterPostViewModel<EmployerTradeCenter>
    {
        public EmployerPostTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutTradeCenterViewModel : CenterPutViewModel<EmployerTradeCenter>
    {
        public EmployerPutTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteTradeCenterViewModel : CenterDeleteViewModel<EmployerTradeCenter>
    {
        public EmployerDeleteTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsTradeCenterViewModel : CenterGetsViewModel<EmployerTradeCenter>
    {
        public EmployerGetsTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
