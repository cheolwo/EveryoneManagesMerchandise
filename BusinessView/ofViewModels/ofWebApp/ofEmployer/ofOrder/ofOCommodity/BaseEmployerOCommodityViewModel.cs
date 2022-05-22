using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerOCommodityViewModel : BaseCommodityViewModel<EmployerOCommodity>
    {
        public BaseEmployerOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostOCommodityViewModel : EmployerCommodityPostViewModel<EmployerOCommodity>
    {
        public EmployerPostOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutOCommodityViewModel : EmployerCommodityPutViewModel<EmployerOCommodity>
    {
        public EmployerPutOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteOCommodityViewModel : EmployerCommodityDeleteViewModel<EmployerOCommodity>
    {
        public EmployerDeleteOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsOCommodityViewModel : EmployerCommodityGetsViewModel<EmployerOCommodity>
    {
        public EmployerGetsOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
