using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofIncomingTag
{
    public class EmployerIncomingTagPageViewModel : EntityPageViewModel<EmployerIncomingTag> 
    {
        public EmployerIncomingTagPageViewModel(EmployerPostIncomingTagViewModel EmployerPostIncomingTagViewModel, 
                                        EmployerPutIncomingTagViewModel EmployerPutIncomingTagViewModel,
                                        EmployerDeleteIncomingTagViewModel EmployerDeleteIncomingTagViewModel,
                                        EmployerGetsIncomingTagViewModel EmployerGetsIncomingTagViewModel)
                :base(EmployerPostIncomingTagViewModel, EmployerPutIncomingTagViewModel, EmployerDeleteIncomingTagViewModel, EmployerGetsIncomingTagViewModel)
                    
        {
            
        }
    }
}