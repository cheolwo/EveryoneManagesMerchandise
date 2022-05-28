using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostMWCommodityViewModel : MWCommodityPostViewModel<EmployerMWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMWCommodityViewModel : MWCommodityPutViewModel<EmployerMWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMWCommodityViewModel : MWCommodityDeleteViewModel<EmployerMWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMWCommodityViewModel : MWCommodityGetsViewModel<EmployerMWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
