using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerSOCommodityViewModel : BaseStatusViewModel<EmployerSOCommodity>
    {
        public BaseEmployerSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSOCommodityViewModel : StatusPostViewModel<EmployerSOCommodity>
    {
        public EmployerPostSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSOCommodityViewModel : StatusPutViewModel<EmployerSOCommodity>
    {
        public EmployerPutSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSOCommodityViewModel : StatusDeleteViewModel<EmployerSOCommodity>
    {
        public EmployerDeleteSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSOCommodityViewModel : StatusGetsViewModel<EmployerSOCommodity>
    {
        public EmployerGetsSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
