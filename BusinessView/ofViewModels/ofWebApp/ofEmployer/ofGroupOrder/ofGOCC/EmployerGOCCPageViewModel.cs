using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOCC
{
    public class EmployerGOCCPageViewModel : CommodityPageViewModel<EmployerGOCC> 
    {
        public EmployerGOCCPageViewModel(EmployerPostGOCCViewModel EmployerPostGOCCViewModel, 
                                        EmployerPutGOCCViewModel EmployerPutGOCCViewModel,
                                        EmployerDeleteGOCCViewModel EmployerDeleteGOCCViewModel,
                                        EmployerGetsGOCCViewModel EmployerGetsGOCCViewModel)
                :base(EmployerPostGOCCViewModel, EmployerPutGOCCViewModel, EmployerDeleteGOCCViewModel, EmployerGetsGOCCViewModel)
                    
        {
            
        }
    }
}