using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofEGOC
{
    public class EmployerEGOCPageViewModel : StatusPageViewModel<EmployerEGOC> 
    {
        public EmployerEGOCPageViewModel(EmployerPostEGOCViewModel EmployerPostEGOCViewModel, 
                                        EmployerPutEGOCViewModel EmployerPutEGOCViewModel,
                                        EmployerDeleteEGOCViewModel EmployerDeleteEGOCViewModel,
                                        EmployerGetsEGOCViewModel EmployerGetsEGOCViewModel)
                :base(EmployerPostEGOCViewModel, EmployerPutEGOCViewModel, EmployerDeleteEGOCViewModel, EmployerGetsEGOCViewModel)
                    
        {
            
        }
    }
}