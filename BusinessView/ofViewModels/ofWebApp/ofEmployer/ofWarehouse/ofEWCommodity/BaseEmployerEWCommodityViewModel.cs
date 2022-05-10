using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerEWCommodityViewModel : BaseStatusViewModel<EmployerEWCommodity>
    {
        public BaseEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostEWCommodityViewModel : StatusPostViewModel<EmployerEWCommodity>
    {
        public EmployerPostEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutEWCommodityViewModel : StatusPutViewModel<EmployerEWCommodity>
    {
        public EmployerPutEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteEWCommodityViewModel : StatusDeleteViewModel<EmployerEWCommodity>
    {
        public EmployerDeleteEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsEWCommodityViewModel : StatusGetsViewModel<EmployerEWCommodity>
    {
        public EmployerGetsEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
