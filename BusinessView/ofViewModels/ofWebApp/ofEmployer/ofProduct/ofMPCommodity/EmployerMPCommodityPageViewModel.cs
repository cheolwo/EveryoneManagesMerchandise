using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofMPCommodity
{
    public class EmployerMPCommodityPageViewModel : StatusPageViewModel<EmployerMPCommodity> 
    {
        public EmployerMPCommodityPageViewModel(EmployerPostMPCommodityViewModel EmployerPostMPCommodityViewModel, 
                                        EmployerPutMPCommodityViewModel EmployerPutMPCommodityViewModel,
                                        EmployerDeleteMPCommodityViewModel EmployerDeleteMPCommodityViewModel,
                                        EmployerGetsMPCommodityViewModel EmployerGetsMPCommodityViewModel)
                :base(EmployerPostMPCommodityViewModel, EmployerPutMPCommodityViewModel, EmployerDeleteMPCommodityViewModel, EmployerGetsMPCommodityViewModel)
                    
        {
            
        }
    }
}