using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofDTO.ofMarket;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket
{
    public class PlatMarketPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : PlatMarketDTO, new()
    {
        private readonly PlatMarketPostViewModel<TMStatus> _PlatMarketPostViewModel;
        private readonly PlatMarketPutViewModel<TMStatus> _PlatMarketPutViewModel;
        private readonly PlatMarketDeleteViewModel<TMStatus> _PlatMarketDeleteViewModel;
        private readonly PlatMarketGetsViewModel<TMStatus> _PlatMarketGetViewMode;
        public PlatMarketPageViewModel(
            PlatMarketPostViewModel<TMStatus> PlatMarketPostViewModel, 
            PlatMarketPutViewModel<TMStatus> PlatMarketPutViewModel,
            PlatMarketDeleteViewModel<TMStatus> PlatMarketDeleteViewModel, 
            PlatMarketGetsViewModel<TMStatus> PlatMarketGetViewModel)
                                            :base(PlatMarketPostViewModel, PlatMarketPutViewModel, PlatMarketDeleteViewModel, PlatMarketGetViewModel)
        {
            _PlatMarketPostViewModel = PlatMarketPostViewModel;
            _PlatMarketDeleteViewModel = PlatMarketDeleteViewModel;
            _PlatMarketGetViewMode = PlatMarketGetViewModel;
            _PlatMarketPutViewModel = PlatMarketPutViewModel;
        }
    }
}