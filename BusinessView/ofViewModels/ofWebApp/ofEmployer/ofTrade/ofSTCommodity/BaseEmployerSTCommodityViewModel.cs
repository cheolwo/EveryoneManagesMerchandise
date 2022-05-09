using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerSTCommodityViewModel : BaseStatusViewModel<EmployerSTCommodity>
    {
        public BaseEmployerSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSTCommodityViewModel : StatusPostViewModel<EmployerSTCommodity>
    {
        public EmployerPostSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSTCommodityViewModel : StatusPutViewModel<EmployerSTCommodity>
    {
        public EmployerPutSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSTCommodityViewModel : StatusDeleteViewModel<EmployerSTCommodity>
    {
        public EmployerDeleteSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSTCommodityViewModel : StatusGetsViewModel<EmployerSTCommodity>
    {
        public EmployerGetsSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
