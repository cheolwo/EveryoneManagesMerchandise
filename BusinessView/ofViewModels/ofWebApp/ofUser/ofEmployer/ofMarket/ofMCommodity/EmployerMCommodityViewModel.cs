using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class EmployerPostMCommodityViewModel : MCommodityPostViewModel<EmployerMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMCommodityViewModel : MCommodityPutViewModel<EmployerMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMCommodityViewModel : MCommodityDeleteViewModel<EmployerMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMCommodityViewModel : MCommodityGetsViewModel<EmployerMCommodity>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
