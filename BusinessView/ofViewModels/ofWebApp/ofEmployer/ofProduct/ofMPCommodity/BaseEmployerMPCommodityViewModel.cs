using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerMPCommodityViewModel : BaseStatusViewModel<EmployerMPCommodity>
    {
        public BaseEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMPCommodityViewModel : StatusPostViewModel<EmployerMPCommodity>
    {
        public EmployerPostMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMPCommodityViewModel : StatusPutViewModel<EmployerMPCommodity>
    {
        public EmployerPutMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMPCommodityViewModel : StatusDeleteViewModel<EmployerMPCommodity>
    {
        public EmployerDeleteMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMPCommodityViewModel : StatusGetsViewModel<EmployerMPCommodity>
    {
        public EmployerGetsMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
