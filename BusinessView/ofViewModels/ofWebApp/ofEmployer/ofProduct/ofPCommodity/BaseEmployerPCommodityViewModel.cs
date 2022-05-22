using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerPCommodityViewModel : BaseCommodityViewModel<EmployerPCommodity>
    {
        public BaseEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostPCommodityViewModel : EmployerCommodityPostViewModel<EmployerPCommodity>
    {
        public EmployerPostPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutPCommodityViewModel : EmployerCommodityPutViewModel<EmployerPCommodity>
    {
        public EmployerPutPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeletePCommodityViewModel : EmployerCommodityDeleteViewModel<EmployerPCommodity>
    {
        public EmployerDeletePCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsPCommodityViewModel : EmployerCommodityGetsViewModel<EmployerPCommodity>
    {
        public EmployerGetsPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
