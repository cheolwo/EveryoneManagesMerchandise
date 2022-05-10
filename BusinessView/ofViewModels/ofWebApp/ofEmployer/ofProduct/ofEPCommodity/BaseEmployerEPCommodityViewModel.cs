using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerEPCommodityViewModel : BaseStatusViewModel<EmployerEPCommodity>
    {
        public BaseEmployerEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEPCommodityViewModel : StatusPostViewModel<EmployerEPCommodity>
    {
        public EmployerPostEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEPCommodityViewModel : StatusPutViewModel<EmployerEPCommodity>
    {
        public EmployerPutEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEPCommodityViewModel : StatusDeleteViewModel<EmployerEPCommodity>
    {
        public EmployerDeleteEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEPCommodityViewModel : StatusGetsViewModel<EmployerEPCommodity>
    {
        public EmployerGetsEPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
