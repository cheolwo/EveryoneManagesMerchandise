using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofETCommodity
{
    public class EmployerETCommodityPageViewModel : StatusPageViewModel<EmployerETCommodity> 
    {
        public EmployerETCommodityPageViewModel(EmployerPostETCommodityViewModel EmployerPostETCommodityViewModel, 
                                        EmployerPutETCommodityViewModel EmployerPutETCommodityViewModel,
                                        EmployerDeleteETCommodityViewModel EmployerDeleteETCommodityViewModel,
                                        EmployerGetsETCommodityViewModel EmployerGetsETCommodityViewModel)
                :base(EmployerPostETCommodityViewModel, EmployerPutETCommodityViewModel, EmployerDeleteETCommodityViewModel, EmployerGetsETCommodityViewModel)
                    
        {
            
        }
    }
}