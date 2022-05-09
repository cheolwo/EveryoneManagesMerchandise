using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMMCommodity
{
    public class EmployerMMCommodityPageViewModel : StatusPageViewModel<EmployerMMCommodity> 
    {
        public EmployerMMCommodityPageViewModel(EmployerPostMMCommodityViewModel EmployerPostMMCommodityViewModel, 
                                        EmployerPutMMCommodityViewModel EmployerPutMMCommodityViewModel,
                                        EmployerDeleteMMCommodityViewModel EmployerDeleteMMCommodityViewModel,
                                        EmployerGetsMMCommodityViewModel EmployerGetsMMCommodityViewModel)
                :base(EmployerPostMMCommodityViewModel, EmployerPutMMCommodityViewModel, EmployerDeleteMMCommodityViewModel, EmployerGetsMMCommodityViewModel)
                    
        {
            
        }
    }
}