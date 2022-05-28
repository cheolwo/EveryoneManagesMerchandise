using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostSWCommodityViewModel : SWCommodityPostViewModel<EmployerSWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutSWCommodityViewModel : SWCommodityPutViewModel<EmployerSWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteSWCommodityViewModel : SWCommodityDeleteViewModel<EmployerSWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsSWCommodityViewModel : SWCommodityGetsViewModel<EmployerSWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
