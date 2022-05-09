using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofPCommodity
{
    public class EmployerPCommodityPageViewModel : CommodityPageViewModel<EmployerPCommodity> 
    {
        public EmployerPCommodityPageViewModel(EmployerPostPCommodityViewModel EmployerPostPCommodityViewModel, 
                                        EmployerPutPCommodityViewModel EmployerPutPCommodityViewModel,
                                        EmployerDeletePCommodityViewModel EmployerDeletePCommodityViewModel,
                                        EmployerGetsPCommodityViewModel EmployerGetsPCommodityViewModel)
                :base(EmployerPostPCommodityViewModel, EmployerPutPCommodityViewModel, EmployerDeletePCommodityViewModel, EmployerGetsPCommodityViewModel)
                    
        {
            
        }
    }
}