using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMCommodityViewModel : BaseCommodityViewModel<EmployerMCommodity>
    {
        public BaseEmployerMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMCommodityViewModel : CommodityPostViewModel<EmployerMCommodity>
    {
        public EmployerPostMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMCommodityViewModel : CommodityPutViewModel<EmployerMCommodity>
    {
        public EmployerPutMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMCommodityViewModel : CommodityDeleteViewModel<EmployerMCommodity>
    {
        public EmployerDeleteMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMCommodityViewModel : CommodityGetsViewModel<EmployerMCommodity>
    {
        public EmployerGetsMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
