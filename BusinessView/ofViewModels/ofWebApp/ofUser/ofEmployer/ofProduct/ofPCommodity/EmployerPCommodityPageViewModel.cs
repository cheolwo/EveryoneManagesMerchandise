using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofPCommodity
{
    public class EmployerPCommodityPageViewModel : EmployerCommodityPageViewModel<EmployerPCommodity> 
    {
        public readonly EmployerPostPCommodityViewModel _EmployerPostPCommodityViewModel;
        public readonly EmployerPutPCommodityViewModel _EmployerPutPCommodityViewModel;
        public readonly EmployerDeletePCommodityViewModel _EmployerDeletePCommodityViewModel;
        public readonly EmployerGetsPCommodityViewModel _EmployerGetsPCommodityViewModel;
        public EmployerPCommodityPageViewModel(EmployerPostPCommodityViewModel EmployerPostPCommodityViewModel, 
                                        EmployerPutPCommodityViewModel EmployerPutPCommodityViewModel,
                                        EmployerDeletePCommodityViewModel EmployerDeletePCommodityViewModel,
                                        EmployerGetsPCommodityViewModel EmployerGetsPCommodityViewModel)
                :base(EmployerPostPCommodityViewModel, EmployerPutPCommodityViewModel, EmployerDeletePCommodityViewModel, EmployerGetsPCommodityViewModel)
                    
        {
            _EmployerPostPCommodityViewModel = EmployerPostPCommodityViewModel;
            _EmployerPutPCommodityViewModel = EmployerPutPCommodityViewModel;
            _EmployerDeletePCommodityViewModel = EmployerDeletePCommodityViewModel;
            _EmployerGetsPCommodityViewModel = EmployerGetsPCommodityViewModel;
        }
    }
}