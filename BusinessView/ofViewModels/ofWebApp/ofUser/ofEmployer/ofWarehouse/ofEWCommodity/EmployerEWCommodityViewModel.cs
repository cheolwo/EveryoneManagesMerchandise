using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostEWCommodityViewModel : EWCommodityPostViewModel<EmployerEWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutEWCommodityViewModel : EWCommodityPutViewModel<EmployerEWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteEWCommodityViewModel : EWCommodityDeleteViewModel<EmployerEWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsEWCommodityViewModel : EWCommodityGetsViewModel<EmployerEWCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
