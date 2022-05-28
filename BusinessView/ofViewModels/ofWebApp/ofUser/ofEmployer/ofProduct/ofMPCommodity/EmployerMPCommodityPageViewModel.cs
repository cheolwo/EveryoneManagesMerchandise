using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofMPCommodity
{
    public class EmployerMPCommodityPageViewModel : MPCommodityPageViewModel<EmployerMPCommodity> 
    {
        public readonly EmployerPostMPCommodityViewModel _EmployerPostMPCommodityViewModel;
        public readonly EmployerPutMPCommodityViewModel _EmployerPutMPCommodityViewModel;
        public readonly EmployerDeleteMPCommodityViewModel _EmployerDeleteMPCommodityViewModel;
        public readonly EmployerGetsMPCommodityViewModel _EmployerGetsMPCommodityViewModel;

        public EmployerMPCommodityPageViewModel(EmployerPostMPCommodityViewModel EmployerPostMPCommodityViewModel, 
                                        EmployerPutMPCommodityViewModel EmployerPutMPCommodityViewModel,
                                        EmployerDeleteMPCommodityViewModel EmployerDeleteMPCommodityViewModel,
                                        EmployerGetsMPCommodityViewModel EmployerGetsMPCommodityViewModel)
                :base(EmployerPostMPCommodityViewModel, EmployerPutMPCommodityViewModel, EmployerDeleteMPCommodityViewModel, EmployerGetsMPCommodityViewModel)
                    
        {
            _EmployerPostMPCommodityViewModel = EmployerPostMPCommodityViewModel;
            _EmployerPutMPCommodityViewModel = EmployerPutMPCommodityViewModel;
            _EmployerDeleteMPCommodityViewModel = EmployerDeleteMPCommodityViewModel;
            _EmployerGetsMPCommodityViewModel = EmployerGetsMPCommodityViewModel;
        }
    }
}