using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerSPCommodityViewModel : BaseStatusViewModel<EmployerSPCommodity>
    {
        public BaseEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSPCommodityViewModel : EmployerStatusPostViewModel<EmployerSPCommodity>
    {
        public EmployerPostSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSPCommodityViewModel : EmployerStatusPutViewModel<EmployerSPCommodity>
    {
        public EmployerPutSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSPCommodityViewModel : EmployerStatusDeleteViewModel<EmployerSPCommodity>
    {
        public EmployerDeleteSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSPCommodityViewModel : EmployerStatusGetsViewModel<EmployerSPCommodity>
    {
        public EmployerGetsSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
