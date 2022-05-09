using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerETCommodityViewModel : BaseStatusViewModel<EmployerETCommodity>
    {
        public BaseEmployerETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostETCommodityViewModel : StatusPostViewModel<EmployerETCommodity>
    {
        public EmployerPostETCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutETCommodityViewModel : StatusPutViewModel<EmployerETCommodity>
    {
        public EmployerPutETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteETCommodityViewModel : StatusDeleteViewModel<EmployerETCommodity>
    {
        public EmployerDeleteETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsETCommodityViewModel : StatusGetsViewModel<EmployerETCommodity>
    {
        public EmployerGetsETCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
