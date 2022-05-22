using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerSMCommodityViewModel : BaseStatusViewModel<EmployerSMCommodity>
    {
        public BaseEmployerSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSMCommodityViewModel : EmployerStatusPostViewModel<EmployerSMCommodity>
    {
        public EmployerPostSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSMCommodityViewModel : EmployerStatusPutViewModel<EmployerSMCommodity>
    {
        public EmployerPutSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSMCommodityViewModel : EmployerStatusDeleteViewModel<EmployerSMCommodity>
    {
        public EmployerDeleteSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSMCommodityViewModel : EmployerStatusGetsViewModel<EmployerSMCommodity>
    {
        public EmployerGetsSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
