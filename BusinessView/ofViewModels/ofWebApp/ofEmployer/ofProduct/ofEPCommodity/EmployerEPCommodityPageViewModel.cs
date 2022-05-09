using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofEPCommodity
{
    public class EmployerEPCommodityPageViewModel : StatusPageViewModel<EmployerEPCommodity> 
    {
        public EmployerEPCommodityPageViewModel(EmployerPostEPCommodityViewModel EmployerPostEPCommodityViewModel, 
                                        EmployerPutEPCommodityViewModel EmployerPutEPCommodityViewModel,
                                        EmployerDeleteEPCommodityViewModel EmployerDeleteEPCommodityViewModel,
                                        EmployerGetsEPCommodityViewModel EmployerGetsEPCommodityViewModel)
                :base(EmployerPostEPCommodityViewModel, EmployerPutEPCommodityViewModel, EmployerDeleteEPCommodityViewModel, EmployerGetsEPCommodityViewModel)
                    
        {
            
        }
    }
}