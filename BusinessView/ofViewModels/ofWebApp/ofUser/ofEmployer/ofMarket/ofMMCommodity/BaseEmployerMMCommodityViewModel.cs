using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMMCommodityViewModel : BaseStatusViewModel<EmployerMMCommodity>
    {
        public BaseEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMMCommodityViewModel : EmployerStatusPostViewModel<EmployerMMCommodity>
    {
        public EmployerPostMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMMCommodityViewModel : EmployerStatusPutViewModel<EmployerMMCommodity>
    {
        public EmployerPutMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMMCommodityViewModel : EmployerStatusDeleteViewModel<EmployerMMCommodity>
    {
        public EmployerDeleteMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMMCommodityViewModel : EmployerStatusGetsViewModel<EmployerMMCommodity>
    {
        public EmployerGetsMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
