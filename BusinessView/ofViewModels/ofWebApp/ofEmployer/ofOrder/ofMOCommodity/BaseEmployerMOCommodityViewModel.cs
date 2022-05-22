using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerMOCommodityViewModel : BaseStatusViewModel<EmployerMOCommodity>
    {
        public BaseEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMOCommodityViewModel : EmployerStatusPostViewModel<EmployerMOCommodity>
    {
        public EmployerPostMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMOCommodityViewModel : EmployerStatusPutViewModel<EmployerMOCommodity>
    {
        public EmployerPutMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMOCommodityViewModel : EmployerStatusDeleteViewModel<EmployerMOCommodity>
    {
        public EmployerDeleteMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMOCommodityViewModel : EmployerStatusGetsViewModel<EmployerMOCommodity>
    {
        public EmployerGetsMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
