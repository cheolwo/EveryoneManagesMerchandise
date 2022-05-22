using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerSWCommodityViewModel : BaseStatusViewModel<EmployerSWCommodity>
    {
        public BaseEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostSWCommodityViewModel : EmployerStatusPostViewModel<EmployerSWCommodity>
    {
        public EmployerPostSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutSWCommodityViewModel : EmployerStatusPutViewModel<EmployerSWCommodity>
    {
        public EmployerPutSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteSWCommodityViewModel : EmployerStatusDeleteViewModel<EmployerSWCommodity>
    {
        public EmployerDeleteSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsSWCommodityViewModel : EmployerStatusGetsViewModel<EmployerSWCommodity>
    {
        public EmployerGetsSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
