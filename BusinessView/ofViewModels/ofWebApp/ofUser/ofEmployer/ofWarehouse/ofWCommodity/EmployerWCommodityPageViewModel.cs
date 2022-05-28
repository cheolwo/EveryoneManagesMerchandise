using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWCommodity
{
    public class EmployerWCommodityPageViewModel : EmployerCommodityPageViewModel<EmployerWCommodity> 
    {
        public readonly EmployerPostWCommodityViewModel _EmployerPostWCommodityViewModel;
        public readonly EmployerPutWCommodityViewModel _EmployerPutWCommodityViewModel;
        public readonly EmployerDeleteWCommodityViewModel _EmployerDeleteWCommodityViewModel;
        public readonly EmployerGetsWCommodityViewModel _EmployerGetsWCommodityViewModel;
        public EmployerWCommodityPageViewModel(EmployerPostWCommodityViewModel EmployerPostWCommodityViewModel, 
                                        EmployerPutWCommodityViewModel EmployerPutWCommodityViewModel,
                                        EmployerDeleteWCommodityViewModel EmployerDeleteWCommodityViewModel,
                                        EmployerGetsWCommodityViewModel EmployerGetsWCommodityViewModel)
                :base(EmployerPostWCommodityViewModel, EmployerPutWCommodityViewModel, EmployerDeleteWCommodityViewModel, EmployerGetsWCommodityViewModel)
                    
        {
             _EmployerPostWCommodityViewModel = EmployerPostWCommodityViewModel;
            _EmployerPutWCommodityViewModel = EmployerPutWCommodityViewModel;
            _EmployerDeleteWCommodityViewModel = EmployerDeleteWCommodityViewModel;
            _EmployerGetsWCommodityViewModel = EmployerGetsWCommodityViewModel;
        }
    }
}