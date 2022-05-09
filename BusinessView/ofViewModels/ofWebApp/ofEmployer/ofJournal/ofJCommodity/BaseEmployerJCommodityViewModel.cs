using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJCommodityViewModel : BaseCommodityViewModel<EmployerJCommodity>
    {
        public BaseEmployerJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostJCommodityViewModel : CommodityPostViewModel<EmployerJCommodity>
    {
        public EmployerPostJCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutJCommodityViewModel : CommodityPutViewModel<EmployerJCommodity>
    {
        public EmployerPutJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteJCommodityViewModel : CommodityDeleteViewModel<EmployerJCommodity>
    {
        public EmployerDeleteJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsJCommodityViewModel : CommodityGetsViewModel<EmployerJCommodity>
    {
        public EmployerGetsJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
