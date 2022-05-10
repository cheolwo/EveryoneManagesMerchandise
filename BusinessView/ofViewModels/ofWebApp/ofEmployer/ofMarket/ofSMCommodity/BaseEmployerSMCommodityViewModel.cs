using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerSMCommodityViewModel : BaseStatusViewModel<EmployerSMCommodity>
    {
        public BaseEmployerSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSMCommodityViewModel : StatusPostViewModel<EmployerSMCommodity>
    {
        public EmployerPostSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSMCommodityViewModel : StatusPutViewModel<EmployerSMCommodity>
    {
        public EmployerPutSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSMCommodityViewModel : StatusDeleteViewModel<EmployerSMCommodity>
    {
        public EmployerDeleteSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSMCommodityViewModel : StatusGetsViewModel<EmployerSMCommodity>
    {
        public EmployerGetsSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
