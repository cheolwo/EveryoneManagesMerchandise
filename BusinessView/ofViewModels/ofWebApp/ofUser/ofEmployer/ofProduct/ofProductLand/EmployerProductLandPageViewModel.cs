using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductLand
{
    public class EmployerProductLandPageViewModel : EmployerPageViewModel<EmployerProductLand> 
    {
        public readonly EmployerPostProductLandViewModel _EmployerPostProductLandViewModel;
        public readonly EmployerPutProductLandViewModel _EmployerPutProductLandViewModel;
        public readonly EmployerDeleteProductLandViewModel _EmployerDeleteProductLandViewModel;
        public readonly EmployerGetsProductLandViewModel _EmployerGetsProductLandViewModel;
        public EmployerProductLandPageViewModel(EmployerPostProductLandViewModel EmployerPostProductLandViewModel, 
                                        EmployerPutProductLandViewModel EmployerPutProductLandViewModel,
                                        EmployerDeleteProductLandViewModel EmployerDeleteProductLandViewModel,
                                        EmployerGetsProductLandViewModel EmployerGetsProductLandViewModel)
                :base(EmployerPostProductLandViewModel, EmployerPutProductLandViewModel, EmployerDeleteProductLandViewModel, EmployerGetsProductLandViewModel)
                    
        {
            _EmployerPostProductLandViewModel = EmployerPostProductLandViewModel;
            _EmployerPutProductLandViewModel = EmployerPutProductLandViewModel;
            _EmployerDeleteProductLandViewModel = EmployerDeleteProductLandViewModel;
            _EmployerGetsProductLandViewModel = EmployerGetsProductLandViewModel;
        }
    }
}