using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerTCommodityViewModel : BaseCommodityViewModel<EmployerTCommodity>
    {
        public BaseEmployerTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostTCommodityViewModel : CommodityPostViewModel<EmployerTCommodity>
    {
        public EmployerPostTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutTCommodityViewModel : CommodityPutViewModel<EmployerTCommodity>
    {
        public EmployerPutTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteTCommodityViewModel : CommodityDeleteViewModel<EmployerTCommodity>
    {
        public EmployerDeleteTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsTCommodityViewModel : CommodityGetsViewModel<EmployerTCommodity>
    {
        public EmployerGetsTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
