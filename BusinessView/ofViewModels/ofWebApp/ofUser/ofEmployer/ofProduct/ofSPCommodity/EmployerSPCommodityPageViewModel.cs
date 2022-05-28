using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofSPCommodity
{
    public class EmployerSPCommodityPageViewModel : SPCommodityPageViewModel<EmployerSPCommodity> 
    {
        public readonly EmployerPostSPCommodityViewModel _EmployerPostSPCommodityViewModel;
        public readonly EmployerPutSPCommodityViewModel _EmployerPutSPCommodityViewModel;
        public readonly EmployerDeleteSPCommodityViewModel _EmployerDeleteSPCommodityViewModel;
        public readonly EmployerGetsSPCommodityViewModel _EmployerGetsSPCommodityViewModel;

        public EmployerSPCommodityPageViewModel(EmployerPostSPCommodityViewModel EmployerPostSPCommodityViewModel, 
                                        EmployerPutSPCommodityViewModel EmployerPutSPCommodityViewModel,
                                        EmployerDeleteSPCommodityViewModel EmployerDeleteSPCommodityViewModel,
                                        EmployerGetsSPCommodityViewModel EmployerGetsSPCommodityViewModel)
                :base(EmployerPostSPCommodityViewModel, EmployerPutSPCommodityViewModel, EmployerDeleteSPCommodityViewModel, EmployerGetsSPCommodityViewModel)
                    
        {
            _EmployerPostSPCommodityViewModel = EmployerPostSPCommodityViewModel;
            _EmployerPutSPCommodityViewModel = EmployerPutSPCommodityViewModel;
            _EmployerDeleteSPCommodityViewModel = EmployerDeleteSPCommodityViewModel;
            _EmployerGetsSPCommodityViewModel = EmployerGetsSPCommodityViewModel;
        }
    }
}