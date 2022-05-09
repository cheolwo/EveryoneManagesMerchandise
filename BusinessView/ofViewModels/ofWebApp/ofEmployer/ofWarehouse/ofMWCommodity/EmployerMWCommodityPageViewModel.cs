using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofMWCommodity
{
    public class EmployerMWCommodityPageViewModel : StatusPageViewModel<EmployerMWCommodity> 
    {
        public EmployerMWCommodityPageViewModel(EmployerPostMWCommodityViewModel EmployerPostMWCommodityViewModel, 
                                        EmployerPutMWCommodityViewModel EmployerPutMWCommodityViewModel,
                                        EmployerDeleteMWCommodityViewModel EmployerDeleteMWCommodityViewModel,
                                        EmployerGetsMWCommodityViewModel EmployerGetsMWCommodityViewModel)
                :base(EmployerPostMWCommodityViewModel, EmployerPutMWCommodityViewModel, EmployerDeleteMWCommodityViewModel, EmployerGetsMWCommodityViewModel)
                    
        {
            
        }
    }
}