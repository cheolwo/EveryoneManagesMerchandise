using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMarketViewModel : BaseCenterViewModel<EmployerMarket>
    {
        public BaseEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMarketViewModel : EmployerCenterPostViewModel<EmployerMarket>
    {
        public EmployerPostMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMarketViewModel : EmployerCenterPutViewModel<EmployerMarket>
    {
        public EmployerPutMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMarketViewModel : EmployerCenterDeleteViewModel<EmployerMarket>
    {
        public EmployerDeleteMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMarketViewModel : EmployerCenterGetsViewModel<EmployerMarket>
    {
        public EmployerGetsMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
