using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofMTCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class EmployerPostMTCommodityViewModel : MTCommodityPostViewModel<EmployerMTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMTCommodityViewModel : MTCommodityPutViewModel<EmployerMTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMTCommodityViewModel : MTCommodityDeleteViewModel<EmployerMTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMTCommodityViewModel : MTCommodityGetsViewModel<EmployerMTCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMTCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
