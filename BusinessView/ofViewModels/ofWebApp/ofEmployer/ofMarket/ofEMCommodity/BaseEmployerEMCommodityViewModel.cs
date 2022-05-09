using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerEMCommodityViewModel : BaseStatusViewModel<EmployerEMCommodity>
    {
        public BaseEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEMCommodityViewModel : StatusPostViewModel<EmployerEMCommodity>
    {
        public EmployerPostEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEMCommodityViewModel : StatusPutViewModel<EmployerEMCommodity>
    {
        public EmployerPutEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEMCommodityViewModel : StatusDeleteViewModel<EmployerEMCommodity>
    {
        public EmployerDeleteEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEMCommodityViewModel : StatusGetsViewModel<EmployerEMCommodity>
    {
        public EmployerGetsEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
