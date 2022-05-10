using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJCommodity
{
    public class EmployerJCommodityPageViewModel : CommodityPageViewModel<EmployerJCommodity> 
    {
        public EmployerJCommodityPageViewModel(EmployerPostJCommodityViewModel EmployerPostJCommodityViewModel, 
                                        EmployerPutJCommodityViewModel EmployerPutJCommodityViewModel,
                                        EmployerDeleteJCommodityViewModel EmployerDeleteJCommodityViewModel,
                                        EmployerGetsJCommodityViewModel EmployerGetsJCommodityViewModel)
                :base(EmployerPostJCommodityViewModel, EmployerPutJCommodityViewModel, EmployerDeleteJCommodityViewModel, EmployerGetsJCommodityViewModel)
                    
        {
            
        }
    }
}