using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal
{
    public class BaseEmployerJCommodityViewModel : BaseCommodityViewModel<EmployerJCommodity>
    {
        public BaseEmployerJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostJCommodityViewModel : EmployerCommodityPostViewModel<EmployerJCommodity>
    {
        public EmployerPostJCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutJCommodityViewModel : EmployerCommodityPutViewModel<EmployerJCommodity>
    {
        public EmployerPutJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteJCommodityViewModel : EmployerCommodityDeleteViewModel<EmployerJCommodity>
    {
        public EmployerDeleteJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsJCommodityViewModel : EmployerCommodityGetsViewModel<EmployerJCommodity>
    {
        public EmployerGetsJCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
