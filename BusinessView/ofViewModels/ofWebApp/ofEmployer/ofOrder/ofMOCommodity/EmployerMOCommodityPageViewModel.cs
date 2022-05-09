using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofMOCommodity
{
    public class EmployerMOCommodityPageViewModel : StatusPageViewModel<EmployerMOCommodity> 
    {
        public EmployerMOCommodityPageViewModel(EmployerPostMOCommodityViewModel EmployerPostMOCommodityViewModel, 
                                        EmployerPutMOCommodityViewModel EmployerPutMOCommodityViewModel,
                                        EmployerDeleteMOCommodityViewModel EmployerDeleteMOCommodityViewModel,
                                        EmployerGetsMOCommodityViewModel EmployerGetsMOCommodityViewModel)
                :base(EmployerPostMOCommodityViewModel, EmployerPutMOCommodityViewModel, EmployerDeleteMOCommodityViewModel, EmployerGetsMOCommodityViewModel)
                    
        {
            
        }
    }
}