using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofSGOC
{
    public class EmployerSGOCPageViewModel : StatusPageViewModel<EmployerSGOC> 
    {
        public EmployerSGOCPageViewModel(EmployerPostSGOCViewModel EmployerPostSGOCViewModel, 
                                        EmployerPutSGOCViewModel EmployerPutSGOCViewModel,
                                        EmployerDeleteSGOCViewModel EmployerDeleteSGOCViewModel,
                                        EmployerGetsSGOCViewModel EmployerGetsSGOCViewModel)
                :base(EmployerPostSGOCViewModel, EmployerPutSGOCViewModel, EmployerDeleteSGOCViewModel, EmployerGetsSGOCViewModel)
                    
        {
            
        }
    }
}