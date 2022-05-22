using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerEPCommodityViewModel : BaseStatusViewModel<EmployerEPCommodity>
    {
        public BaseEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEPCommodityViewModel : EmployerStatusPostViewModel<EmployerEPCommodity>
    {
        public EmployerPostEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEPCommodityViewModel : EmployerStatusPutViewModel<EmployerEPCommodity>
    {
        public EmployerPutEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEPCommodityViewModel : EmployerStatusDeleteViewModel<EmployerEPCommodity>
    {
        public EmployerDeleteEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEPCommodityViewModel : EmployerStatusGetsViewModel<EmployerEPCommodity>
    {
        public EmployerGetsEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
