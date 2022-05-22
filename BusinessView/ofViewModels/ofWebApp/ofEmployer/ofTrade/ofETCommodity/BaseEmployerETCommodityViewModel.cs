using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerETCommodityViewModel : BaseStatusViewModel<EmployerETCommodity>
    {
        public BaseEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostETCommodityViewModel : EmployerStatusPostViewModel<EmployerETCommodity>
    {
        public EmployerPostETCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutETCommodityViewModel : EmployerStatusPutViewModel<EmployerETCommodity>
    {
        public EmployerPutETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteETCommodityViewModel : EmployerStatusDeleteViewModel<EmployerETCommodity>
    {
        public EmployerDeleteETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsETCommodityViewModel : EmployerStatusGetsViewModel<EmployerETCommodity>
    {
        public EmployerGetsETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
