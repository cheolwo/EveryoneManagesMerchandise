using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerMOCommodityViewModel : BaseStatusViewModel<EmployerMOCommodity>
    {
        public BaseEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMOCommodityViewModel : StatusPostViewModel<EmployerMOCommodity>
    {
        public EmployerPostMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMOCommodityViewModel : StatusPutViewModel<EmployerMOCommodity>
    {
        public EmployerPutMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMOCommodityViewModel : StatusDeleteViewModel<EmployerMOCommodity>
    {
        public EmployerDeleteMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMOCommodityViewModel : StatusGetsViewModel<EmployerMOCommodity>
    {
        public EmployerGetsMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
