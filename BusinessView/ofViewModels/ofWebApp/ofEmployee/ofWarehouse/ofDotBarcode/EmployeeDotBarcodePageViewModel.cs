using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDotBarcode
{
    public class EmployeeDotBarcodePageViewModel : EntityPageViewModel<EmployeeDotBarcode> 
    {
        public EmployeeDotBarcodePageViewModel(EmployeePostDotBarcodeViewModel employeePostDotBarcodeViewModel, 
                                        EmployeePutDotBarcodeViewModel employeePutDotBarcodeViewModel,
                                        EmployeeDeleteDotBarcodeViewModel employeeDeleteDotBarcodeViewModel,
                                        EmployeeGetsDotBarcodeViewModel employeeGetsDotBarcodeViewModel)
                :base(employeePostDotBarcodeViewModel, employeePutDotBarcodeViewModel, employeeDeleteDotBarcodeViewModel, employeeGetsDotBarcodeViewModel)
                    
        {
            
        }
    }
}