using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofSTCommodity
{
    public class EmployerSTCommodityPageViewModel : EmployerStatusPageViewModel<EmployerSTCommodity> 
    {
        public readonly EmployerPostSTCommodityViewModel _EmployerPostSTCommodityViewModel;
        public readonly EmployerPutSTCommodityViewModel _EmployerPutSTCommodityViewModel;
        public readonly EmployerDeleteSTCommodityViewModel _EmployerDeleteSTCommodityViewModel;
        public readonly EmployerGetsSTCommodityViewModel _EmployerGetsSTCommodityViewModel;
        public EmployerSTCommodityPageViewModel(EmployerPostSTCommodityViewModel EmployerPostSTCommodityViewModel, 
                                        EmployerPutSTCommodityViewModel EmployerPutSTCommodityViewModel,
                                        EmployerDeleteSTCommodityViewModel EmployerDeleteSTCommodityViewModel,
                                        EmployerGetsSTCommodityViewModel EmployerGetsSTCommodityViewModel)
                :base(EmployerPostSTCommodityViewModel, EmployerPutSTCommodityViewModel, EmployerDeleteSTCommodityViewModel, EmployerGetsSTCommodityViewModel)
                    
        {
            _EmployerPostSTCommodityViewModel = EmployerPostSTCommodityViewModel;
            _EmployerPutSTCommodityViewModel = EmployerPutSTCommodityViewModel;
            _EmployerDeleteSTCommodityViewModel = EmployerDeleteSTCommodityViewModel;
            _EmployerGetsSTCommodityViewModel = EmployerGetsSTCommodityViewModel;
        }
    }
}