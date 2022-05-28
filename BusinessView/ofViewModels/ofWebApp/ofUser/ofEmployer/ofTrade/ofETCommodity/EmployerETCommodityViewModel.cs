using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofETCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class EmployerPostETCommodityViewModel : ETCommodityPostViewModel<EmployerETCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostETCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutETCommodityViewModel : ETCommodityPutViewModel<EmployerETCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteETCommodityViewModel : ETCommodityDeleteViewModel<EmployerETCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsETCommodityViewModel : ETCommodityGetsViewModel<EmployerETCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
