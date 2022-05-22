using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerTCommodityViewModel : BaseCommodityViewModel<EmployerTCommodity>
    {
        public BaseEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostTCommodityViewModel : EmployerCommodityPostViewModel<EmployerTCommodity>
    {
        public EmployerPostTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutTCommodityViewModel : EmployerCommodityPutViewModel<EmployerTCommodity>
    {
        public EmployerPutTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteTCommodityViewModel : EmployerCommodityDeleteViewModel<EmployerTCommodity>
    {
        public EmployerDeleteTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsTCommodityViewModel : EmployerCommodityGetsViewModel<EmployerTCommodity>
    {
        public EmployerGetsTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
