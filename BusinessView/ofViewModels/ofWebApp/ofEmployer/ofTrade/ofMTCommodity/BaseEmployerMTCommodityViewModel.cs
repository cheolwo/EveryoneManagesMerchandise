using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerMTCommodityViewModel : BaseStatusViewModel<EmployerMTCommodity>
    {
        public BaseEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMTCommodityViewModel : StatusPostViewModel<EmployerMTCommodity>
    {
        public EmployerPostMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMTCommodityViewModel : StatusPutViewModel<EmployerMTCommodity>
    {
        public EmployerPutMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMTCommodityViewModel : StatusDeleteViewModel<EmployerMTCommodity>
    {
        public EmployerDeleteMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMTCommodityViewModel : StatusGetsViewModel<EmployerMTCommodity>
    {
        public EmployerGetsMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
