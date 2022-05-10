using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerEOCommodityViewModel : BaseStatusViewModel<EmployerEOCommodity>
    {
        public BaseEmployerEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEOCommodityViewModel : StatusPostViewModel<EmployerEOCommodity>
    {
        public EmployerPostEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEOCommodityViewModel : StatusPutViewModel<EmployerEOCommodity>
    {
        public EmployerPutEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEOCommodityViewModel : StatusDeleteViewModel<EmployerEOCommodity>
    {
        public EmployerDeleteEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEOCommodityViewModel : StatusGetsViewModel<EmployerEOCommodity>
    {
        public EmployerGetsEOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
