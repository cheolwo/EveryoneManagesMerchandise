using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class EmployerPostTradeCenterViewModel : TradeCenterPostViewModel<EmployerTradeCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutTradeCenterViewModel : TradeCenterPutViewModel<EmployerTradeCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteTradeCenterViewModel : TradeCenterDeleteViewModel<EmployerTradeCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsTradeCenterViewModel : TradeCenterGetsViewModel<EmployerTradeCenter>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
