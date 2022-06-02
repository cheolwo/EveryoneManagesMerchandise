using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofSTCommodity;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class EmployerPostSTCommodityViewModel : STCommodityPostViewModel<EmployerSTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutSTCommodityViewModel : STCommodityPutViewModel<EmployerSTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteSTCommodityViewModel : STCommodityDeleteViewModel<EmployerSTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsSTCommodityViewModel : STCommodityGetsViewModel<EmployerSTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsSTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
