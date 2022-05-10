using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofMTCommodity
{
    public class EmployerMTCommodityPageViewModel : StatusPageViewModel<EmployerMTCommodity> 
    {
        public EmployerMTCommodityPageViewModel(EmployerPostMTCommodityViewModel EmployerPostMTCommodityViewModel, 
                                        EmployerPutMTCommodityViewModel EmployerPutMTCommodityViewModel,
                                        EmployerDeleteMTCommodityViewModel EmployerDeleteMTCommodityViewModel,
                                        EmployerGetsMTCommodityViewModel EmployerGetsMTCommodityViewModel)
                :base(EmployerPostMTCommodityViewModel, EmployerPutMTCommodityViewModel, EmployerDeleteMTCommodityViewModel, EmployerGetsMTCommodityViewModel)
                    
        {
            
        }
    }
}