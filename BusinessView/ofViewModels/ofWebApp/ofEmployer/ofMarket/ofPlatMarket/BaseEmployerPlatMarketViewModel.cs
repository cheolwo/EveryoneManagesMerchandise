using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerPlatMarketViewModel : BaseCenterViewModel<EmployerPlatMarket>
    {
        public BaseEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostPlatMarketViewModel : EmployerCenterPostViewModel<EmployerPlatMarket>
    {
        public EmployerPostPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutPlatMarketViewModel : EmployerCenterPutViewModel<EmployerPlatMarket>
    {
        public EmployerPutPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeletePlatMarketViewModel : EmployerCenterDeleteViewModel<EmployerPlatMarket>
    {
        public EmployerDeletePlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsPlatMarketViewModel : EmployerCenterGetsViewModel<EmployerPlatMarket>
    {
        public EmployerGetsPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
