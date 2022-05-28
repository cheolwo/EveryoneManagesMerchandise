using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerSOCommodityViewModel : BaseStatusViewModel<EmployerSOCommodity>
    {
        public BaseEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSOCommodityViewModel : EmployerStatusPostViewModel<EmployerSOCommodity>
    {
        public EmployerPostSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSOCommodityViewModel : EmployerStatusPutViewModel<EmployerSOCommodity>
    {
        public EmployerPutSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSOCommodityViewModel : EmployerStatusDeleteViewModel<EmployerSOCommodity>
    {
        public EmployerDeleteSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSOCommodityViewModel : EmployerStatusGetsViewModel<EmployerSOCommodity>
    {
        public EmployerGetsSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
