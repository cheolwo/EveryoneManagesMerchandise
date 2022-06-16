using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofSMCommodity
{
    public class EmployerSMCommodityPageViewModel : SMCommodityPageViewModel<EmployerSMCommodity>
    {
        public readonly EmployerPostSMCommodityViewModel _EmployerPostSMCommodityViewModel;
        public readonly EmployerPutSMCommodityViewModel _EmployerPutSMCommodityViewModel;
        public readonly EmployerDeleteSMCommodityViewModel _EmployerDeleteSMCommodityViewModel;
        public readonly EmployerGetsSMCommodityViewModel _EmployerGetsSMCommodityViewModel;

        public EmployerSMCommodityPageViewModel(EmployerPostSMCommodityViewModel EmployerPostSMCommodityViewModel, 
                                        EmployerPutSMCommodityViewModel EmployerPutSMCommodityViewModel,
                                        EmployerDeleteSMCommodityViewModel EmployerDeleteSMCommodityViewModel,
                                        EmployerGetsSMCommodityViewModel EmployerGetsSMCommodityViewModel)
                :base(EmployerPostSMCommodityViewModel, EmployerPutSMCommodityViewModel, EmployerDeleteSMCommodityViewModel, EmployerGetsSMCommodityViewModel)
                    
        {
            _EmployerPostSMCommodityViewModel = EmployerPostSMCommodityViewModel;
            _EmployerPutSMCommodityViewModel = EmployerPutSMCommodityViewModel;
            _EmployerDeleteSMCommodityViewModel = EmployerDeleteSMCommodityViewModel;
            _EmployerGetsSMCommodityViewModel = EmployerGetsSMCommodityViewModel;
        }
    }
}