using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTradeCenter
{
    public class EmployerTradeCenterPageViewModel : TradeCenterPageViewModel<EmployerTradeCenter> 
    {
        public readonly EmployerPostTradeCenterViewModel _EmployerPostTradeCenterViewModel;
        public readonly EmployerPutTradeCenterViewModel _EmployerPutTradeCenterViewModel;
        public readonly EmployerDeleteTradeCenterViewModel _EmployerDeleteTradeCenterViewModel;
        public readonly EmployerGetsTradeCenterViewModel _EmployerGetsTradeCenterViewModel;

        public EmployerTradeCenterPageViewModel(EmployerPostTradeCenterViewModel EmployerPostTradeCenterViewModel, 
                                        EmployerPutTradeCenterViewModel EmployerPutTradeCenterViewModel,
                                        EmployerDeleteTradeCenterViewModel EmployerDeleteTradeCenterViewModel,
                                        EmployerGetsTradeCenterViewModel EmployerGetsTradeCenterViewModel)
                :base(EmployerPostTradeCenterViewModel, EmployerPutTradeCenterViewModel, EmployerDeleteTradeCenterViewModel, EmployerGetsTradeCenterViewModel)
                    
        {
            _EmployerPostTradeCenterViewModel = EmployerPostTradeCenterViewModel;
            _EmployerPutTradeCenterViewModel = EmployerPutTradeCenterViewModel;
            _EmployerDeleteTradeCenterViewModel = EmployerDeleteTradeCenterViewModel;
            _EmployerGetsTradeCenterViewModel = EmployerGetsTradeCenterViewModel;
        }
    }
}