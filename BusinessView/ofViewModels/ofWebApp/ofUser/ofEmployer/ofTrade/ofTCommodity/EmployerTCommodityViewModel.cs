using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class EmployerPostTCommodityViewModel : TCommodityPostViewModel<EmployerTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutTCommodityViewModel : TCommodityPutViewModel<EmployerTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteTCommodityViewModel : TCommodityDeleteViewModel<EmployerTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsTCommodityViewModel : TCommodityGetsViewModel<EmployerTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
