using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofLoadFrame
{
    public class EmployerLoadFramePageViewModel : EntityPageViewModel<EmployerLoadFrame> 
    {
        public EmployerLoadFramePageViewModel(EmployerPostLoadFrameViewModel EmployerPostLoadFrameViewModel, 
                                        EmployerPutLoadFrameViewModel EmployerPutLoadFrameViewModel,
                                        EmployerDeleteLoadFrameViewModel EmployerDeleteLoadFrameViewModel,
                                        EmployerGetsLoadFrameViewModel EmployerGetsLoadFrameViewModel)
                :base(EmployerPostLoadFrameViewModel, EmployerPutLoadFrameViewModel, EmployerDeleteLoadFrameViewModel, EmployerGetsLoadFrameViewModel)
                    
        {
            
        }
    }
}