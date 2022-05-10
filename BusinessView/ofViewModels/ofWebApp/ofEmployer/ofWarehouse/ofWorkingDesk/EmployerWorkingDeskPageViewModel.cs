using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWorkingDesk
{
    public class EmployerWorkingDeskPageViewModel : EntityPageViewModel<EmployerWorkingDesk> 
    {
        public EmployerWorkingDeskPageViewModel(EmployerPostWorkingDeskViewModel EmployerPostWorkingDeskViewModel, 
                                        EmployerPutWorkingDeskViewModel EmployerPutWorkingDeskViewModel,
                                        EmployerDeleteWorkingDeskViewModel EmployerDeleteWorkingDeskViewModel,
                                        EmployerGetsWorkingDeskViewModel EmployerGetsWorkingDeskViewModel)
                :base(EmployerPostWorkingDeskViewModel, EmployerPutWorkingDeskViewModel, EmployerDeleteWorkingDeskViewModel, EmployerGetsWorkingDeskViewModel)
                    
        {
            
        }
    }
}