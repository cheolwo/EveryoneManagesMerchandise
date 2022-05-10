using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofSOCommodity
{
    public class EmployerSOCommodityPageViewModel : StatusPageViewModel<EmployerSOCommodity> 
    {
        public EmployerSOCommodityPageViewModel(EmployerPostSOCommodityViewModel EmployerPostSOCommodityViewModel, 
                                        EmployerPutSOCommodityViewModel EmployerPutSOCommodityViewModel,
                                        EmployerDeleteSOCommodityViewModel EmployerDeleteSOCommodityViewModel,
                                        EmployerGetsSOCommodityViewModel EmployerGetsSOCommodityViewModel)
                :base(EmployerPostSOCommodityViewModel, EmployerPutSOCommodityViewModel, EmployerDeleteSOCommodityViewModel, EmployerGetsSOCommodityViewModel)
                    
        {
            
        }
    }
}