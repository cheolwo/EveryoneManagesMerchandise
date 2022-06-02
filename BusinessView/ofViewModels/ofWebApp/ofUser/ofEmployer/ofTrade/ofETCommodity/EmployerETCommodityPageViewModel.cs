using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofTrade.ofETCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofETCommodity
{
    public class EmployerETCommodityPageViewModel : ETCommodityPageViewModel<EmployerETCommodity> 
    {
        public readonly EmployerPostETCommodityViewModel _EmployerPostETCommodityViewModel;
        public readonly EmployerPutETCommodityViewModel _EmployerPutETCommodityViewModel;
        public readonly EmployerDeleteETCommodityViewModel _EmployerDeleteETCommodityViewModel;
        public readonly EmployerGetsETCommodityViewModel _EmployerGetsETCommodityViewModel;

        public EmployerETCommodityPageViewModel(EmployerPostETCommodityViewModel EmployerPostETCommodityViewModel, 
                                        EmployerPutETCommodityViewModel EmployerPutETCommodityViewModel,
                                        EmployerDeleteETCommodityViewModel EmployerDeleteETCommodityViewModel,
                                        EmployerGetsETCommodityViewModel EmployerGetsETCommodityViewModel)
                :base(EmployerPostETCommodityViewModel, EmployerPutETCommodityViewModel, EmployerDeleteETCommodityViewModel, EmployerGetsETCommodityViewModel)
                    
        {
            _EmployerPostETCommodityViewModel = EmployerPostETCommodityViewModel;
            _EmployerPutETCommodityViewModel = EmployerPutETCommodityViewModel;
            _EmployerDeleteETCommodityViewModel = EmployerDeleteETCommodityViewModel;
            _EmployerGetsETCommodityViewModel = EmployerGetsETCommodityViewModel;
        }
    }
}