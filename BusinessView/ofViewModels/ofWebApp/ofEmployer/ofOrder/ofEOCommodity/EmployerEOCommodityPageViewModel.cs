using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofEOCommodity
{
    public class EmployerEOCommodityPageViewModel : StatusPageViewModel<EmployerEOCommodity> 
    {
        public EmployerEOCommodityPageViewModel(EmployerPostEOCommodityViewModel EmployerPostEOCommodityViewModel, 
                                        EmployerPutEOCommodityViewModel EmployerPutEOCommodityViewModel,
                                        EmployerDeleteEOCommodityViewModel EmployerDeleteEOCommodityViewModel,
                                        EmployerGetsEOCommodityViewModel EmployerGetsEOCommodityViewModel)
                :base(EmployerPostEOCommodityViewModel, EmployerPutEOCommodityViewModel, EmployerDeleteEOCommodityViewModel, EmployerGetsEOCommodityViewModel)
                    
        {
            
        }
    }
}