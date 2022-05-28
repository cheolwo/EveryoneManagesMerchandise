using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class EmployerPostPlatMarketViewModel : PlatMarketPostViewModel<EmployerPlatMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutPlatMarketViewModel : PlatMarketPutViewModel<EmployerPlatMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeletePlatMarketViewModel : PlatMarketDeleteViewModel<EmployerPlatMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeletePlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsPlatMarketViewModel : PlatMarketGetsViewModel<EmployerPlatMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
