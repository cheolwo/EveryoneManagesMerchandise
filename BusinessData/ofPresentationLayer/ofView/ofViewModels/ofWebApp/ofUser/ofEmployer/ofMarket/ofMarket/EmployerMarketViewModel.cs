using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class EmployerPostMarketViewModel : MarketPostViewModel<EmployerMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostMarketViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutMarketViewModel : MarketPutViewModel<EmployerMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteMarketViewModel : MarketDeleteViewModel<EmployerMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsMarketViewModel : MarketGetsViewModel<EmployerMarket>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsMarketViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}