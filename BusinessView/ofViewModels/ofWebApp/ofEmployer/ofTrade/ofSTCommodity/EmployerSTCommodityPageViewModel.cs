using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofSTCommodity
{
    public class EmployerSTCommodityPageViewModel : StatusPageViewModel<EmployerSTCommodity> 
    {
        public EmployerSTCommodityPageViewModel(EmployerPostSTCommodityViewModel EmployerPostSTCommodityViewModel, 
                                        EmployerPutSTCommodityViewModel EmployerPutSTCommodityViewModel,
                                        EmployerDeleteSTCommodityViewModel EmployerDeleteSTCommodityViewModel,
                                        EmployerGetsSTCommodityViewModel EmployerGetsSTCommodityViewModel)
                :base(EmployerPostSTCommodityViewModel, EmployerPutSTCommodityViewModel, EmployerDeleteSTCommodityViewModel, EmployerGetsSTCommodityViewModel)
                    
        {
            
        }
    }
}