using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMarket
{
    public class EmployerMarketPageViewModel : MarketPageViewModel<EmployerMarket> 
    {
        public readonly EmployerPostMarketViewModel _EmployerPostMarketViewModel;
        public readonly EmployerPutMarketViewModel _EmployerPutMarketViewModel;
        public readonly EmployerDeleteMarketViewModel _EmployerDeleteMarketViewModel;
        public readonly EmployerGetsMarketViewModel _EmployerGetsMarketViewModel;

        public EmployerMarketPageViewModel(EmployerPostMarketViewModel EmployerPostMarketViewModel, 
                                        EmployerPutMarketViewModel EmployerPutMarketViewModel,
                                        EmployerDeleteMarketViewModel EmployerDeleteMarketViewModel,
                                        EmployerGetsMarketViewModel EmployerGetsMarketViewModel)
                :base(EmployerPostMarketViewModel, EmployerPutMarketViewModel, EmployerDeleteMarketViewModel, EmployerGetsMarketViewModel)
                    
        {
            _EmployerPostMarketViewModel = EmployerPostMarketViewModel;
            _EmployerPutMarketViewModel = EmployerPutMarketViewModel;
            _EmployerDeleteMarketViewModel = EmployerDeleteMarketViewModel;
            _EmployerGetsMarketViewModel = EmployerGetsMarketViewModel;
        }
    }
}