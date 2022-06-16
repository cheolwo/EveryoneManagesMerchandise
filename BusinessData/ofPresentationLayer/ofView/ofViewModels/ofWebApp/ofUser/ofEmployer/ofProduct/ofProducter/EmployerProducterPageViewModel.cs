using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProducter
{
    public class EmployerProducterPageViewModel : ProducterPageViewModel<EmployerProducter> 
    {
        public readonly EmployerPostProducterViewModel _EmployerPostProducterViewModel;
        public readonly EmployerPutProducterViewModel _EmployerPutProducterViewModel;
        public readonly EmployerDeleteProducterViewModel _EmployerDeleteProducterViewModel;
        public readonly EmployerGetsProducterViewModel _EmployerGetsProducterViewModel;

        public EmployerProducterPageViewModel(EmployerPostProducterViewModel EmployerPostProducterViewModel, 
                                        EmployerPutProducterViewModel EmployerPutProducterViewModel,
                                        EmployerDeleteProducterViewModel EmployerDeleteProducterViewModel,
                                        EmployerGetsProducterViewModel EmployerGetsProducterViewModel)
                :base(EmployerPostProducterViewModel, EmployerPutProducterViewModel, EmployerDeleteProducterViewModel, EmployerGetsProducterViewModel)
                    
        {
            _EmployerPostProducterViewModel = EmployerPostProducterViewModel;
            _EmployerPutProducterViewModel = EmployerPutProducterViewModel;
            _EmployerDeleteProducterViewModel = EmployerDeleteProducterViewModel;
            _EmployerGetsProducterViewModel = EmployerGetsProducterViewModel;
        }
    }
}