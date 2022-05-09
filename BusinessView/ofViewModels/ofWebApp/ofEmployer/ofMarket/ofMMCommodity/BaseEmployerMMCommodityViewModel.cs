using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMMCommodityViewModel : BaseStatusViewModel<EmployerMMCommodity>
    {
        public BaseEmployerMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMMCommodityViewModel : StatusPostViewModel<EmployerMMCommodity>
    {
        public EmployerPostMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMMCommodityViewModel : StatusPutViewModel<EmployerMMCommodity>
    {
        public EmployerPutMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMMCommodityViewModel : StatusDeleteViewModel<EmployerMMCommodity>
    {
        public EmployerDeleteMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMMCommodityViewModel : StatusGetsViewModel<EmployerMMCommodity>
    {
        public EmployerGetsMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
