using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerEWCommodityViewModel : BaseStatusViewModel<EmployerEWCommodity>
    {
        public BaseEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEWCommodityViewModel : EmployerStatusPostViewModel<EmployerEWCommodity>
    {
        public EmployerPostEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEWCommodityViewModel : EmployerStatusPutViewModel<EmployerEWCommodity>
    {
        public EmployerPutEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEWCommodityViewModel : EmployerStatusDeleteViewModel<EmployerEWCommodity>
    {
        public EmployerDeleteEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEWCommodityViewModel : EmployerStatusGetsViewModel<EmployerEWCommodity>
    {
        public EmployerGetsEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
