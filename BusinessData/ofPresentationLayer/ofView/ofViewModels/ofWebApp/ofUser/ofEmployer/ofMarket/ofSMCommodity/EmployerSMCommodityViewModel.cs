using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class EmployerPostSMCommodityViewModel : SMCommodityPostViewModel<EmployerSMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutSMCommodityViewModel : SMCommodityPutViewModel<EmployerSMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteSMCommodityViewModel : SMCommodityDeleteViewModel<EmployerSMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsSMCommodityViewModel : SMCommodityGetsViewModel<EmployerSMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsSMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
