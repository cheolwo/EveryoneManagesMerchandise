using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerMWCommodityViewModel : BaseStatusViewModel<EmployerMWCommodity>
    {
        public BaseEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMWCommodityViewModel : EmployerStatusPostViewModel<EmployerMWCommodity>
    {
        public EmployerPostMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMWCommodityViewModel : EmployerStatusPutViewModel<EmployerMWCommodity>
    {
        public EmployerPutMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMWCommodityViewModel : EmployerStatusDeleteViewModel<EmployerMWCommodity>
    {
        public EmployerDeleteMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMWCommodityViewModel : EmployerStatusGetsViewModel<EmployerMWCommodity>
    {
        public EmployerGetsMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
