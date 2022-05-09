using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerSWCommodityViewModel : BaseStatusViewModel<EmployerSWCommodity>
    {
        public BaseEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSWCommodityViewModel : StatusPostViewModel<EmployerSWCommodity>
    {
        public EmployerPostSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSWCommodityViewModel : StatusPutViewModel<EmployerSWCommodity>
    {
        public EmployerPutSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSWCommodityViewModel : StatusDeleteViewModel<EmployerSWCommodity>
    {
        public EmployerDeleteSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSWCommodityViewModel : StatusGetsViewModel<EmployerSWCommodity>
    {
        public EmployerGetsSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
