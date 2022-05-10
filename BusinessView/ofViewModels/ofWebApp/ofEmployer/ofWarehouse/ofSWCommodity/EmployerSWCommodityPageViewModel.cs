using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofSWCommodity
{
    public class EmployerSWCommodityPageViewModel : StatusPageViewModel<EmployerSWCommodity> 
    {
        public EmployerSWCommodityPageViewModel(EmployerPostSWCommodityViewModel EmployerPostSWCommodityViewModel, 
                                        EmployerPutSWCommodityViewModel EmployerPutSWCommodityViewModel,
                                        EmployerDeleteSWCommodityViewModel EmployerDeleteSWCommodityViewModel,
                                        EmployerGetsSWCommodityViewModel EmployerGetsSWCommodityViewModel)
                :base(EmployerPostSWCommodityViewModel, EmployerPutSWCommodityViewModel, EmployerDeleteSWCommodityViewModel, EmployerGetsSWCommodityViewModel)
                    
        {
            
        }
    }
}