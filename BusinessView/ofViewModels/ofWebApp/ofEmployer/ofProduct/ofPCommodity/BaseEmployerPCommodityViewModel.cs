using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerPCommodityViewModel : BaseCommodityViewModel<EmployerPCommodity>
    {
        public BaseEmployerPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostPCommodityViewModel : CommodityPostViewModel<EmployerPCommodity>
    {
        public EmployerPostPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutPCommodityViewModel : CommodityPutViewModel<EmployerPCommodity>
    {
        public EmployerPutPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeletePCommodityViewModel : CommodityDeleteViewModel<EmployerPCommodity>
    {
        public EmployerDeletePCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsPCommodityViewModel : CommodityGetsViewModel<EmployerPCommodity>
    {
        public EmployerGetsPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
