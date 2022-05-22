using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerEMCommodityViewModel : BaseStatusViewModel<EmployerEMCommodity>
    {
        public BaseEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEMCommodityViewModel : EmployerStatusPostViewModel<EmployerEMCommodity>
    {
        public EmployerPostEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEMCommodityViewModel : EmployerStatusPutViewModel<EmployerEMCommodity>
    {
        public EmployerPutEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEMCommodityViewModel : EmployerStatusDeleteViewModel<EmployerEMCommodity>
    {
        public EmployerDeleteEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEMCommodityViewModel : EmployerStatusGetsViewModel<EmployerEMCommodity>
    {
        public EmployerGetsEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
