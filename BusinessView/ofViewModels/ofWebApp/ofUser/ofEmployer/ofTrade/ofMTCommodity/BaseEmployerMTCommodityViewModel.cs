using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerMTCommodityViewModel : BaseStatusViewModel<EmployerMTCommodity>
    {
        public BaseEmployerMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMTCommodityViewModel : EmployerStatusPostViewModel<EmployerMTCommodity>
    {
        public EmployerPostMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMTCommodityViewModel : EmployerStatusPutViewModel<EmployerMTCommodity>
    {
        public EmployerPutMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMTCommodityViewModel : EmployerStatusDeleteViewModel<EmployerMTCommodity>
    {
        public EmployerDeleteMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMTCommodityViewModel : EmployerStatusGetsViewModel<EmployerMTCommodity>
    {
        public EmployerGetsMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
