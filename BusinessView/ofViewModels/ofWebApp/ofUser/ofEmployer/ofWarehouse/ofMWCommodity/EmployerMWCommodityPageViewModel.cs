using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofMWCommodity
{
    public class EmployerMWCommodityPageViewModel : MWCommodityPageViewModel<EmployerMWCommodity> 
    {
        public readonly EmployerPostMWCommodityViewModel _EmployerPostMWCommodityViewModel;
        public readonly EmployerPutMWCommodityViewModel _EmployerPutMWCommodityViewModel;
        public readonly EmployerDeleteMWCommodityViewModel _EmployerDeleteMWCommodityViewModel;
        public readonly EmployerGetsMWCommodityViewModel _EmployerGetsMWCommodityViewModel;

        public EmployerMWCommodityPageViewModel(EmployerPostMWCommodityViewModel EmployerPostMWCommodityViewModel, 
                                        EmployerPutMWCommodityViewModel EmployerPutMWCommodityViewModel,
                                        EmployerDeleteMWCommodityViewModel EmployerDeleteMWCommodityViewModel,
                                        EmployerGetsMWCommodityViewModel EmployerGetsMWCommodityViewModel)
                :base(EmployerPostMWCommodityViewModel, EmployerPutMWCommodityViewModel, EmployerDeleteMWCommodityViewModel, EmployerGetsMWCommodityViewModel)
                    
        {
            _EmployerPostMWCommodityViewModel = EmployerPostMWCommodityViewModel;
            _EmployerPutMWCommodityViewModel = EmployerPutMWCommodityViewModel;
            _EmployerDeleteMWCommodityViewModel = EmployerDeleteMWCommodityViewModel;
            _EmployerGetsMWCommodityViewModel = EmployerGetsMWCommodityViewModel;
        }
    }
}