using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofSMCommodity
{
    public class EmployerSMCommodityPageViewModel : StatusPageViewModel<EmployerSMCommodity> 
    {
        public EmployerSMCommodityPageViewModel(EmployerPostSMCommodityViewModel EmployerPostSMCommodityViewModel, 
                                        EmployerPutSMCommodityViewModel EmployerPutSMCommodityViewModel,
                                        EmployerDeleteSMCommodityViewModel EmployerDeleteSMCommodityViewModel,
                                        EmployerGetsSMCommodityViewModel EmployerGetsSMCommodityViewModel)
                :base(EmployerPostSMCommodityViewModel, EmployerPutSMCommodityViewModel, EmployerDeleteSMCommodityViewModel, EmployerGetsSMCommodityViewModel)
                    
        {
            
        }
    }
}