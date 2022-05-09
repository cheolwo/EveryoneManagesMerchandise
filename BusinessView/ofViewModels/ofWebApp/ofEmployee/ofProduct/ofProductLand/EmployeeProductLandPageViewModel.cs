using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductLand
{
    public class EmployeeProductLandPageViewModel : EntityPageViewModel<EmployeeProductLand> 
    {
        public EmployeeProductLandPageViewModel(EmployeePostProductLandViewModel employeePostProductLandViewModel, 
                                        EmployeePutProductLandViewModel employeePutProductLandViewModel,
                                        EmployeeDeleteProductLandViewModel employeeDeleteProductLandViewModel,
                                        EmployeeGetsProductLandViewModel employeeGetsProductLandViewModel)
                :base(employeePostProductLandViewModel, employeePutProductLandViewModel, employeeDeleteProductLandViewModel, employeeGetsProductLandViewModel)
                    
        {
            
        }
    }
}