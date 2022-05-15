using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOCC
{
    public class EmployerGOCCPageViewModel : CommodityPageViewModel<EmployerGOCC> 
    {
        public readonly EmployerPostGOCCViewModel _EmployerPostGOCCViewModel;
        public readonly EmployerPutGOCCViewModel _EmployerPutGOCCViewModel;
        public readonly EmployerDeleteGOCCViewModel _EmployerDeleteGOCCViewModel;
        public readonly EmployerGetsGOCCViewModel _EmployerGetsGOCCViewModel;
        public EmployerGOCCPageViewModel(EmployerPostGOCCViewModel EmployerPostGOCCViewModel, 
                                        EmployerPutGOCCViewModel EmployerPutGOCCViewModel,
                                        EmployerDeleteGOCCViewModel EmployerDeleteGOCCViewModel,
                                        EmployerGetsGOCCViewModel EmployerGetsGOCCViewModel)
                :base(EmployerPostGOCCViewModel, EmployerPutGOCCViewModel, EmployerDeleteGOCCViewModel, EmployerGetsGOCCViewModel)
                    
        {
            _EmployerPostGOCCViewModel = EmployerPostGOCCViewModel;
            _EmployerPutGOCCViewModel = EmployerPutGOCCViewModel;
            _EmployerDeleteGOCCViewModel = EmployerDeleteGOCCViewModel;
            _EmployerGetsGOCCViewModel = EmployerGetsGOCCViewModel;
        }
    }
}