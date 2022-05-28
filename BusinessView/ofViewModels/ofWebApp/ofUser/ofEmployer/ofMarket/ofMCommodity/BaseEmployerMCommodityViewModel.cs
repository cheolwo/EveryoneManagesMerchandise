using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMCommodityViewModel : BaseCommodityViewModel<EmployerMCommodity>
    {
        public BaseEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMCommodityViewModel : EmployerCommodityPostViewModel<EmployerMCommodity>
    {
        public EmployerPostMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMCommodityViewModel : EmployerCommodityPutViewModel<EmployerMCommodity>
    {
        public EmployerPutMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMCommodityViewModel : EmployerCommodityDeleteViewModel<EmployerMCommodity>
    {
        public EmployerDeleteMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMCommodityViewModel : EmployerCommodityGetsViewModel<EmployerMCommodity>
    {
        public EmployerGetsMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
