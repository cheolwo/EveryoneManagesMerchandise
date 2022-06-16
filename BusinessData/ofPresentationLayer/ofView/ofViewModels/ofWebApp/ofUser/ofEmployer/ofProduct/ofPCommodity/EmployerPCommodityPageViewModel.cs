using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;

using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofPCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofPCommodity
{
    public class EmployerPCommodityPageViewModel : PCommodityPageViewModel<EmployerPCommodity> 
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