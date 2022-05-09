using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerSPCommodityViewModel : BaseStatusViewModel<EmployerSPCommodity>
    {
        public BaseEmployerSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSPCommodityViewModel : StatusPostViewModel<EmployerSPCommodity>
    {
        public EmployerPostSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSPCommodityViewModel : StatusPutViewModel<EmployerSPCommodity>
    {
        public EmployerPutSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSPCommodityViewModel : StatusDeleteViewModel<EmployerSPCommodity>
    {
        public EmployerDeleteSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSPCommodityViewModel : StatusGetsViewModel<EmployerSPCommodity>
    {
        public EmployerGetsSPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
