using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDotBarcode
{
    public class EmployeeDotBarcodePageViewModel : DotBarcodePageViewModel<EmployeeDotBarcode> 
    {
        public readonly EmployeePostDotBarcodeViewModel _EmployeePostDotBarcodeViewModel;
        public readonly EmployeePutDotBarcodeViewModel _EmployeePutDotBarcodeViewModel;
        public readonly EmployeeDeleteDotBarcodeViewModel _EmployeeDeleteDotBarcodeViewModel;
        public readonly EmployeeGetsDotBarcodeViewModel _EmployeeGetsDotBarcodeViewModel;
        public EmployeeDotBarcodePageViewModel(EmployeePostDotBarcodeViewModel employeePostDotBarcodeViewModel, 
                                        EmployeePutDotBarcodeViewModel employeePutDotBarcodeViewModel,
                                        EmployeeDeleteDotBarcodeViewModel employeeDeleteDotBarcodeViewModel,
                                        EmployeeGetsDotBarcodeViewModel employeeGetsDotBarcodeViewModel)
                :base(employeePostDotBarcodeViewModel, employeePutDotBarcodeViewModel, employeeDeleteDotBarcodeViewModel, employeeGetsDotBarcodeViewModel)
                    
        {
            _EmployeePostDotBarcodeViewModel = employeePostDotBarcodeViewModel;
            _EmployeePutDotBarcodeViewModel = employeePutDotBarcodeViewModel;
            _EmployeeDeleteDotBarcodeViewModel = employeeDeleteDotBarcodeViewModel;
            _EmployeeGetsDotBarcodeViewModel = employeeGetsDotBarcodeViewModel;
        }
    }
}