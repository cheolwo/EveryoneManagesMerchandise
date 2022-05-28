using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostWCommodityViewModel : WCommodityPostViewModel<EmployerWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutWCommodityViewModel : WCommodityPutViewModel<EmployerWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteWCommodityViewModel : WCommodityDeleteViewModel<EmployerWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsWCommodityViewModel : WCommodityGetsViewModel<EmployerWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
