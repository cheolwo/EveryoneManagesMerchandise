using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMMCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class EmployerPostMMCommodityViewModel : MMCommodityPostViewModel<EmployerMMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMMCommodityViewModel : MMCommodityPutViewModel<EmployerMMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMMCommodityViewModel : MMCommodityDeleteViewModel<EmployerMMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMMCommodityViewModel : MMCommodityGetsViewModel<EmployerMMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
