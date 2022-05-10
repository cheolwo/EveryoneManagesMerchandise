using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTCommodity
{
    public class EmployerTCommodityPageViewModel : CommodityPageViewModel<EmployerTCommodity> 
    {
        public EmployerTCommodityPageViewModel(EmployerPostTCommodityViewModel EmployerPostTCommodityViewModel, 
                                        EmployerPutTCommodityViewModel EmployerPutTCommodityViewModel,
                                        EmployerDeleteTCommodityViewModel EmployerDeleteTCommodityViewModel,
                                        EmployerGetsTCommodityViewModel EmployerGetsTCommodityViewModel)
                :base(EmployerPostTCommodityViewModel, EmployerPutTCommodityViewModel, EmployerDeleteTCommodityViewModel, EmployerGetsTCommodityViewModel)
                    
        {
            
        }
    }
}