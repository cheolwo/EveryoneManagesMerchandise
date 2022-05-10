using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductLand
{
    public class EmployerProductLandPageViewModel : EntityPageViewModel<EmployerProductLand> 
    {
        public EmployerProductLandPageViewModel(EmployerPostProductLandViewModel EmployerPostProductLandViewModel, 
                                        EmployerPutProductLandViewModel EmployerPutProductLandViewModel,
                                        EmployerDeleteProductLandViewModel EmployerDeleteProductLandViewModel,
                                        EmployerGetsProductLandViewModel EmployerGetsProductLandViewModel)
                :base(EmployerPostProductLandViewModel, EmployerPutProductLandViewModel, EmployerDeleteProductLandViewModel, EmployerGetsProductLandViewModel)
                    
        {
            
        }
    }
}