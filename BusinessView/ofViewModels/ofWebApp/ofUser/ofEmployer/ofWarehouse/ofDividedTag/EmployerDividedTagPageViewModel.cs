using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofDividedTag
{
    public class EmployerDividedTagPageViewModel : EmployerPageViewModel<EmployerDividedTag> 
    {
        public readonly EmployerPostDividedTagViewModel _EmployerPostDividedTagViewModel;
        public readonly EmployerPutDividedTagViewModel _EmployerPutDividedTagViewModel;
        public readonly EmployerDeleteDividedTagViewModel _EmployerDeleteDividedTagViewModel;
        public readonly EmployerGetsDividedTagViewModel _EmployerGetsDividedTagViewModel;
        public EmployerDividedTagPageViewModel(EmployerPostDividedTagViewModel EmployerPostDividedTagViewModel, 
                                        EmployerPutDividedTagViewModel EmployerPutDividedTagViewModel,
                                        EmployerDeleteDividedTagViewModel EmployerDeleteDividedTagViewModel,
                                        EmployerGetsDividedTagViewModel EmployerGetsDividedTagViewModel)
                :base(EmployerPostDividedTagViewModel, EmployerPutDividedTagViewModel, EmployerDeleteDividedTagViewModel, EmployerGetsDividedTagViewModel)
                    
        {
            _EmployerPostDividedTagViewModel = EmployerPostDividedTagViewModel;
            _EmployerPutDividedTagViewModel = EmployerPutDividedTagViewModel;
            _EmployerDeleteDividedTagViewModel = EmployerDeleteDividedTagViewModel;
            _EmployerGetsDividedTagViewModel = EmployerGetsDividedTagViewModel;
        }
    }
}