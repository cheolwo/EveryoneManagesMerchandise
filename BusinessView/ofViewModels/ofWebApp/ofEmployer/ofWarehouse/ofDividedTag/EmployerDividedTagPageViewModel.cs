using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofDividedTag
{
    public class EmployerDividedTagPageViewModel : EntityPageViewModel<EmployerDividedTag> 
    {
        public EmployerDividedTagPageViewModel(EmployerPostDividedTagViewModel EmployerPostDividedTagViewModel, 
                                        EmployerPutDividedTagViewModel EmployerPutDividedTagViewModel,
                                        EmployerDeleteDividedTagViewModel EmployerDeleteDividedTagViewModel,
                                        EmployerGetsDividedTagViewModel EmployerGetsDividedTagViewModel)
                :base(EmployerPostDividedTagViewModel, EmployerPutDividedTagViewModel, EmployerDeleteDividedTagViewModel, EmployerGetsDividedTagViewModel)
                    
        {
            
        }
    }
}