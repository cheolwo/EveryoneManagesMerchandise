using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerOCommodityViewModel : BaseCommodityViewModel<EmployerOCommodity>
    {
        public BaseEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostOCommodityViewModel : CommodityPostViewModel<EmployerOCommodity>
    {
        public EmployerPostOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutOCommodityViewModel : CommodityPutViewModel<EmployerOCommodity>
    {
        public EmployerPutOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteOCommodityViewModel : CommodityDeleteViewModel<EmployerOCommodity>
    {
        public EmployerDeleteOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsOCommodityViewModel : CommodityGetsViewModel<EmployerOCommodity>
    {
        public EmployerGetsOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
