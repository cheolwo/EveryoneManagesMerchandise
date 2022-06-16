using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOC
{
    public class EmployerGOCPageViewModel : GOCPageViewModel<EmployerGOC> 
    {
        public readonly EmployerPostGOCViewModel _EmployerPostGOCViewModel;
        public readonly EmployerPutGOCViewModel _EmployerPutGOCViewModel;
        public readonly EmployerDeleteGOCViewModel _EmployerDeleteGOCViewModel;
        public readonly EmployerGetsGOCViewModel _EmployerGetsGOCViewModel;

        public EmployerGOCPageViewModel(EmployerPostGOCViewModel EmployerPostGOCViewModel, 
                                        EmployerPutGOCViewModel EmployerPutGOCViewModel,
                                        EmployerDeleteGOCViewModel EmployerDeleteGOCViewModel,
                                        EmployerGetsGOCViewModel EmployerGetsGOCViewModel)
                :base(EmployerPostGOCViewModel, EmployerPutGOCViewModel, EmployerDeleteGOCViewModel, EmployerGetsGOCViewModel)
                    
        {
            _EmployerPostGOCViewModel = EmployerPostGOCViewModel;
            _EmployerPutGOCViewModel = EmployerPutGOCViewModel;
            _EmployerDeleteGOCViewModel = EmployerDeleteGOCViewModel;
            _EmployerGetsGOCViewModel = EmployerGetsGOCViewModel;
        }
    }
}