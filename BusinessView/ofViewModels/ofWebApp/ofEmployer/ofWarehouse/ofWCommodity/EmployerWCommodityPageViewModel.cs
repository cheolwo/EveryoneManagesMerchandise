using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWCommodity
{
    public class EmployerWCommodityPageViewModel : CommodityPageViewModel<EmployerWCommodity> 
    {
        public EmployerWCommodityPageViewModel(EmployerPostWCommodityViewModel EmployerPostWCommodityViewModel, 
                                        EmployerPutWCommodityViewModel EmployerPutWCommodityViewModel,
                                        EmployerDeleteWCommodityViewModel EmployerDeleteWCommodityViewModel,
                                        EmployerGetsWCommodityViewModel EmployerGetsWCommodityViewModel)
                :base(EmployerPostWCommodityViewModel, EmployerPutWCommodityViewModel, EmployerDeleteWCommodityViewModel, EmployerGetsWCommodityViewModel)
                    
        {
            
        }
    }
}