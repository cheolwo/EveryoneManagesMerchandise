using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWorkingDesk
{
    public class EmployerWorkingDeskPageViewModel : EmployerPageViewModel<EmployerWorkingDesk> 
    {
        public readonly EmployerPostWorkingDeskViewModel _EmployerPostWorkingDeskViewModel;
        public readonly EmployerPutWorkingDeskViewModel _EmployerPutWorkingDeskViewModel;
        public readonly EmployerDeleteWorkingDeskViewModel _EmployerDeleteWorkingDeskViewModel;
        public readonly EmployerGetsWorkingDeskViewModel _EmployerGetsWorkingDeskViewModel;
        public EmployerWorkingDeskPageViewModel(EmployerPostWorkingDeskViewModel EmployerPostWorkingDeskViewModel, 
                                        EmployerPutWorkingDeskViewModel EmployerPutWorkingDeskViewModel,
                                        EmployerDeleteWorkingDeskViewModel EmployerDeleteWorkingDeskViewModel,
                                        EmployerGetsWorkingDeskViewModel EmployerGetsWorkingDeskViewModel)
                :base(EmployerPostWorkingDeskViewModel, EmployerPutWorkingDeskViewModel, EmployerDeleteWorkingDeskViewModel, EmployerGetsWorkingDeskViewModel)
                    
        {
            _EmployerPostWorkingDeskViewModel = EmployerPostWorkingDeskViewModel;
            _EmployerPutWorkingDeskViewModel = EmployerPutWorkingDeskViewModel;
            _EmployerDeleteWorkingDeskViewModel = EmployerDeleteWorkingDeskViewModel;
            _EmployerGetsWorkingDeskViewModel = EmployerGetsWorkingDeskViewModel;
        }
    }
}