using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerMPCommodityViewModel : BaseStatusViewModel<EmployerMPCommodity>
    {
        public BaseEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMPCommodityViewModel : EmployerStatusPostViewModel<EmployerMPCommodity>
    {
        public EmployerPostMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMPCommodityViewModel : EmployerStatusPutViewModel<EmployerMPCommodity>
    {
        public EmployerPutMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMPCommodityViewModel : EmployerStatusDeleteViewModel<EmployerMPCommodity>
    {
        public EmployerDeleteMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMPCommodityViewModel : EmployerStatusGetsViewModel<EmployerMPCommodity>
    {
        public EmployerGetsMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
