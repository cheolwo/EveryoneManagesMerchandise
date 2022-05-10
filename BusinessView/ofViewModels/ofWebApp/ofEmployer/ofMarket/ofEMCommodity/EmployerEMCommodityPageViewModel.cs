using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofEMCommodity
{
    public class EmployerEMCommodityPageViewModel : StatusPageViewModel<EmployerEMCommodity> 
    {
        public EmployerEMCommodityPageViewModel(EmployerPostEMCommodityViewModel EmployerPostEMCommodityViewModel, 
                                        EmployerPutEMCommodityViewModel EmployerPutEMCommodityViewModel,
                                        EmployerDeleteEMCommodityViewModel EmployerDeleteEMCommodityViewModel,
                                        EmployerGetsEMCommodityViewModel EmployerGetsEMCommodityViewModel)
                :base(EmployerPostEMCommodityViewModel, EmployerPutEMCommodityViewModel, EmployerDeleteEMCommodityViewModel, EmployerGetsEMCommodityViewModel)
                    
        {
            
        }
    }
}