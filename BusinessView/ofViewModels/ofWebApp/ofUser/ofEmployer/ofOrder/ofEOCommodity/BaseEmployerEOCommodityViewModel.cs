using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerEOCommodityViewModel : BaseStatusViewModel<EmployerEOCommodity>
    {
        public BaseEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEOCommodityViewModel : EmployerStatusPostViewModel<EmployerEOCommodity>
    {
        public EmployerPostEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEOCommodityViewModel : EmployerStatusPutViewModel<EmployerEOCommodity>
    {
        public EmployerPutEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEOCommodityViewModel : EmployerStatusDeleteViewModel<EmployerEOCommodity>
    {
        public EmployerDeleteEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEOCommodityViewModel : EmployerStatusGetsViewModel<EmployerEOCommodity>
    {
        public EmployerGetsEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
