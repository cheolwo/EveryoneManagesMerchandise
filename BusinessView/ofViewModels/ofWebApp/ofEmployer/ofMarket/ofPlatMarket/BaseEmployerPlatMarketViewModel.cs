using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerPlatMarketViewModel : BaseCenterViewModel<EmployerPlatMarket>
    {
        public BaseEmployerPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostPlatMarketViewModel : CenterPostViewModel<EmployerPlatMarket>
    {
        public EmployerPostPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutPlatMarketViewModel : CenterPutViewModel<EmployerPlatMarket>
    {
        public EmployerPutPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeletePlatMarketViewModel : CenterDeleteViewModel<EmployerPlatMarket>
    {
        public EmployerDeletePlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsPlatMarketViewModel : CenterGetsViewModel<EmployerPlatMarket>
    {
        public EmployerGetsPlatMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
