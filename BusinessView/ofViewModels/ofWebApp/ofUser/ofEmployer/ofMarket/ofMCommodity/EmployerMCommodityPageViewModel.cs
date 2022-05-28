using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMCommodity
{
    public class EmployerMCommodityPageViewModel : MCommodityPageViewModel<EmployerMCommodity> 
    {
        public readonly EmployerPostMCommodityViewModel _EmployerPostMCommodityViewModel;
        public readonly EmployerPutMCommodityViewModel _EmployerPutMCommodityViewModel;
        public readonly EmployerDeleteMCommodityViewModel _EmployerDeleteMCommodityViewModel;
        public readonly EmployerGetsMCommodityViewModel _EmployerGetsMCommodityViewModel;

        public EmployerMCommodityPageViewModel(EmployerPostMCommodityViewModel EmployerPostMCommodityViewModel, 
                                        EmployerPutMCommodityViewModel EmployerPutMCommodityViewModel,
                                        EmployerDeleteMCommodityViewModel EmployerDeleteMCommodityViewModel,
                                        EmployerGetsMCommodityViewModel EmployerGetsMCommodityViewModel)
                :base(EmployerPostMCommodityViewModel, EmployerPutMCommodityViewModel, EmployerDeleteMCommodityViewModel, EmployerGetsMCommodityViewModel)
                    
        {
            _EmployerPostMCommodityViewModel = EmployerPostMCommodityViewModel;
            _EmployerPutMCommodityViewModel = EmployerPutMCommodityViewModel;
            _EmployerDeleteMCommodityViewModel = EmployerDeleteMCommodityViewModel;
            _EmployerGetsMCommodityViewModel = EmployerGetsMCommodityViewModel;
        }
    }
}