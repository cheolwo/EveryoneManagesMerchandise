using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerMarketViewModel : BaseCenterViewModel<EmployerMarket>
    {
        public BaseEmployerMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostMarketViewModel : CenterPostViewModel<EmployerMarket>
    {
        public EmployerPostMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutMarketViewModel : CenterPutViewModel<EmployerMarket>
    {
        public EmployerPutMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteMarketViewModel : CenterDeleteViewModel<EmployerMarket>
    {
        public EmployerDeleteMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsMarketViewModel : CenterGetsViewModel<EmployerMarket>
    {
        public EmployerGetsMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
