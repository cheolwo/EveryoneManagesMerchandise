using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofMGOC
{
    public class EmployerMGOCPageViewModel : MGOCPageViewModel<EmployerMGOC> 
    {
        public readonly EmployerPostMGOCViewModel _EmployerPostMGOCViewModel;
        public readonly EmployerPutMGOCViewModel _EmployerPutMGOCViewModel;
        public readonly EmployerDeleteMGOCViewModel _EmployerDeleteMGOCViewModel;
        public readonly EmployerGetsMGOCViewModel _EmployerGetsMGOCViewModel;

        public EmployerMGOCPageViewModel(EmployerPostMGOCViewModel EmployerPostMGOCViewModel, 
                                        EmployerPutMGOCViewModel EmployerPutMGOCViewModel,
                                        EmployerDeleteMGOCViewModel EmployerDeleteMGOCViewModel,
                                        EmployerGetsMGOCViewModel EmployerGetsMGOCViewModel)
                :base(EmployerPostMGOCViewModel, EmployerPutMGOCViewModel, EmployerDeleteMGOCViewModel, EmployerGetsMGOCViewModel)
                    
        {
            _EmployerPostMGOCViewModel = EmployerPostMGOCViewModel;
            _EmployerPutMGOCViewModel = EmployerPutMGOCViewModel;
            _EmployerDeleteMGOCViewModel = EmployerDeleteMGOCViewModel;
            _EmployerGetsMGOCViewModel = EmployerGetsMGOCViewModel;
        }
    }
}