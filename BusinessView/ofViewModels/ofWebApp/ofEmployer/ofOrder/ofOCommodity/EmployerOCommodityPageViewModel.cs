using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofOCommodity
{
    public class EmployerOCommodityPageViewModel : CommodityPageViewModel<EmployerOCommodity> 
    {
        public EmployerOCommodityPageViewModel(EmployerPostOCommodityViewModel EmployerPostOCommodityViewModel, 
                                        EmployerPutOCommodityViewModel EmployerPutOCommodityViewModel,
                                        EmployerDeleteOCommodityViewModel EmployerDeleteOCommodityViewModel,
                                        EmployerGetsOCommodityViewModel EmployerGetsOCommodityViewModel)
                :base(EmployerPostOCommodityViewModel, EmployerPutOCommodityViewModel, EmployerDeleteOCommodityViewModel, EmployerGetsOCommodityViewModel)
                    
        {
            
        }
    }
}