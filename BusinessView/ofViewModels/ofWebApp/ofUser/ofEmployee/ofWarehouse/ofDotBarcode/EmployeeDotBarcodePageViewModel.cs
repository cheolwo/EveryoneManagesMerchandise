using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDotBarcode
{
    public class EmployeeDotBarcodePageViewModel : EntityPageViewModel<EmployeeDotBarcode> 
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