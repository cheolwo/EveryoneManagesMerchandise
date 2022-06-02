using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofIncomingTag
{
    public class EmployerIncomingTagPageViewModel : IncomingTagPageViewModel<EmployerIncomingTag> 
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