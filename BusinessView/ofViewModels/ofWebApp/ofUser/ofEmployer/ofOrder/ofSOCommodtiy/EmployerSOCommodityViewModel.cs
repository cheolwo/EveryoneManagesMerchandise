using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class EmployerPostSOCommodityViewModel : SOCommodityPostViewModel<EmployerSOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutSOCommodityViewModel : SOCommodityPutViewModel<EmployerSOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteSOCommodityViewModel : SOCommodityDeleteViewModel<EmployerSOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsSOCommodityViewModel : SOCommodityGetsViewModel<EmployerSOCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsSOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
