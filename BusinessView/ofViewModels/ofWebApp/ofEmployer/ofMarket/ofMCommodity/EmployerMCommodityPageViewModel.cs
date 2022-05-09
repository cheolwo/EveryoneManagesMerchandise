using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMCommodity
{
    public class EmployerMCommodityPageViewModel : CommodityPageViewModel<EmployerMCommodity> 
    {
        public EmployerMCommodityPageViewModel(EmployerPostMCommodityViewModel EmployerPostMCommodityViewModel, 
                                        EmployerPutMCommodityViewModel EmployerPutMCommodityViewModel,
                                        EmployerDeleteMCommodityViewModel EmployerDeleteMCommodityViewModel,
                                        EmployerGetsMCommodityViewModel EmployerGetsMCommodityViewModel)
                :base(EmployerPostMCommodityViewModel, EmployerPutMCommodityViewModel, EmployerDeleteMCommodityViewModel, EmployerGetsMCommodityViewModel)
                    
        {
            
        }
    }
}