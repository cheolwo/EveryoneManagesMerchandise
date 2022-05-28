using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofIncomingTag
{
    public class EmployerIncomingTagPageViewModel : EmployerPageViewModel<EmployerIncomingTag> 
    {
        public readonly EmployerPostIncomingTagViewModel _EmployerPostIncomingTagViewModel;
        public readonly EmployerPutIncomingTagViewModel _EmployerPutIncomingTagViewModel;
        public readonly EmployerDeleteIncomingTagViewModel _EmployerDeleteIncomingTagViewModel;
        public readonly EmployerGetsIncomingTagViewModel _EmployerGetsIncomingTagViewModel;
        public EmployerIncomingTagPageViewModel(EmployerPostIncomingTagViewModel EmployerPostIncomingTagViewModel, 
                                        EmployerPutIncomingTagViewModel EmployerPutIncomingTagViewModel,
                                        EmployerDeleteIncomingTagViewModel EmployerDeleteIncomingTagViewModel,
                                        EmployerGetsIncomingTagViewModel EmployerGetsIncomingTagViewModel)
                :base(EmployerPostIncomingTagViewModel, EmployerPutIncomingTagViewModel, EmployerDeleteIncomingTagViewModel, EmployerGetsIncomingTagViewModel)
                    
        {
            _EmployerPostIncomingTagViewModel = EmployerPostIncomingTagViewModel;
            _EmployerPutIncomingTagViewModel = EmployerPutIncomingTagViewModel;
            _EmployerDeleteIncomingTagViewModel = EmployerDeleteIncomingTagViewModel;
            _EmployerGetsIncomingTagViewModel = EmployerGetsIncomingTagViewModel;
        }
    }
}