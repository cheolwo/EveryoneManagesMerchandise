using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofMGOC
{
    public class EmployerMGOCPageViewModel : StatusPageViewModel<EmployerMGOC> 
    {
        public EmployerMGOCPageViewModel(EmployerPostMGOCViewModel EmployerPostMGOCViewModel, 
                                        EmployerPutMGOCViewModel EmployerPutMGOCViewModel,
                                        EmployerDeleteMGOCViewModel EmployerDeleteMGOCViewModel,
                                        EmployerGetsMGOCViewModel EmployerGetsMGOCViewModel)
                :base(EmployerPostMGOCViewModel, EmployerPutMGOCViewModel, EmployerDeleteMGOCViewModel, EmployerGetsMGOCViewModel)
                    
        {
            
        }
    }
}