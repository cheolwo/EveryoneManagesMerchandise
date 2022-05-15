using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofSMCommodity
{
    public class EmployerSMCommodityPageViewModel : StatusPageViewModel<EmployerSMCommodity> 
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