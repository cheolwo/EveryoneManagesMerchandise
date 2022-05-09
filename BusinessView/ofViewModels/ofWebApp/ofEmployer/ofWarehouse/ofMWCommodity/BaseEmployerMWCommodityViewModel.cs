using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerMWCommodityViewModel : BaseStatusViewModel<EmployerMWCommodity>
    {
        public BaseEmployerMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMWCommodityViewModel : StatusPostViewModel<EmployerMWCommodity>
    {
        public EmployerPostMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMWCommodityViewModel : StatusPutViewModel<EmployerMWCommodity>
    {
        public EmployerPutMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMWCommodityViewModel : StatusDeleteViewModel<EmployerMWCommodity>
    {
        public EmployerDeleteMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMWCommodityViewModel : StatusGetsViewModel<EmployerMWCommodity>
    {
        public EmployerGetsMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
