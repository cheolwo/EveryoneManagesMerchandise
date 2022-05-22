using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerSTCommodityViewModel : BaseStatusViewModel<EmployerSTCommodity>
    {
        public BaseEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSTCommodityViewModel : EmployerStatusPostViewModel<EmployerSTCommodity>
    {
        public EmployerPostSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSTCommodityViewModel : EmployerStatusPutViewModel<EmployerSTCommodity>
    {
        public EmployerPutSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSTCommodityViewModel : EmployerStatusDeleteViewModel<EmployerSTCommodity>
    {
        public EmployerDeleteSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSTCommodityViewModel : EmployerStatusGetsViewModel<EmployerSTCommodity>
    {
        public EmployerGetsSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
