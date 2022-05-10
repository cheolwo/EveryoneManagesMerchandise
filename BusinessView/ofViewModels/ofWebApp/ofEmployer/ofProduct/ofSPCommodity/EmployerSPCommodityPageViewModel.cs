using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofSPCommodity
{
    public class EmployerSPCommodityPageViewModel : StatusPageViewModel<EmployerSPCommodity> 
    {
        public EmployerSPCommodityPageViewModel(EmployerPostSPCommodityViewModel EmployerPostSPCommodityViewModel, 
                                        EmployerPutSPCommodityViewModel EmployerPutSPCommodityViewModel,
                                        EmployerDeleteSPCommodityViewModel EmployerDeleteSPCommodityViewModel,
                                        EmployerGetsSPCommodityViewModel EmployerGetsSPCommodityViewModel)
                :base(EmployerPostSPCommodityViewModel, EmployerPutSPCommodityViewModel, EmployerDeleteSPCommodityViewModel, EmployerGetsSPCommodityViewModel)
                    
        {
            
        }
    }
}