using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofLoadFrame
{
    public class EmployerLoadFramePageViewModel : LoadFramePageViewModel<EmployerLoadFrame> 
    {
        public readonly EmployerPostLoadFrameViewModel _EmployerPostLoadFrameViewModel;
        public readonly EmployerPutLoadFrameViewModel _EmployerPutLoadFrameViewModel;
        public readonly EmployerDeleteLoadFrameViewModel _EmployerDeleteLoadFrameViewModel;
        public readonly EmployerGetsLoadFrameViewModel _EmployerGetsLoadFrameViewModel;

        public EmployerLoadFramePageViewModel(EmployerPostLoadFrameViewModel EmployerPostLoadFrameViewModel, 
                                        EmployerPutLoadFrameViewModel EmployerPutLoadFrameViewModel,
                                        EmployerDeleteLoadFrameViewModel EmployerDeleteLoadFrameViewModel,
                                        EmployerGetsLoadFrameViewModel EmployerGetsLoadFrameViewModel)
                :base(EmployerPostLoadFrameViewModel, EmployerPutLoadFrameViewModel, EmployerDeleteLoadFrameViewModel, EmployerGetsLoadFrameViewModel)
                    
        {
            _EmployerPostLoadFrameViewModel = EmployerPostLoadFrameViewModel;
            _EmployerPutLoadFrameViewModel = EmployerPutLoadFrameViewModel;
            _EmployerDeleteLoadFrameViewModel = EmployerDeleteLoadFrameViewModel;
            _EmployerGetsLoadFrameViewModel = EmployerGetsLoadFrameViewModel;
        }
    }
}