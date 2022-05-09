using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofEWCommodity
{
    public class EmployerEWCommodityPageViewModel : StatusPageViewModel<EmployerEWCommodity> 
    {
        public EmployerEWCommodityPageViewModel(EmployerPostEWCommodityViewModel EmployerPostEWCommodityViewModel, 
                                        EmployerPutEWCommodityViewModel EmployerPutEWCommodityViewModel,
                                        EmployerDeleteEWCommodityViewModel EmployerDeleteEWCommodityViewModel,
                                        EmployerGetsEWCommodityViewModel EmployerGetsEWCommodityViewModel)
                :base(EmployerPostEWCommodityViewModel, EmployerPutEWCommodityViewModel, EmployerDeleteEWCommodityViewModel, EmployerGetsEWCommodityViewModel)
                    
        {
            
        }
    }
}