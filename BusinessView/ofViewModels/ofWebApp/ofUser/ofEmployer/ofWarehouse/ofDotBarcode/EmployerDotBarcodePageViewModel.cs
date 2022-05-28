﻿using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofDotBarcode
{
    public class EmployerDotBarcodePageViewModel : DotBarcodePageViewModel<EmployerDotBarcode> 
    {
        public readonly EmployerPostDotBarcodeViewModel _EmployerPostDotBarcodeViewModel;
        public readonly EmployerPutDotBarcodeViewModel _EmployerPutDotBarcodeViewModel;
        public readonly EmployerDeleteDotBarcodeViewModel _EmployerDeleteDotBarcodeViewModel;
        public readonly EmployerGetsDotBarcodeViewModel _EmployerGetsDotBarcodeViewModel;

        public EmployerDotBarcodePageViewModel(EmployerPostDotBarcodeViewModel EmployerPostDotBarcodeViewModel, 
                                        EmployerPutDotBarcodeViewModel EmployerPutDotBarcodeViewModel,
                                        EmployerDeleteDotBarcodeViewModel EmployerDeleteDotBarcodeViewModel,
                                        EmployerGetsDotBarcodeViewModel EmployerGetsDotBarcodeViewModel)
                :base(EmployerPostDotBarcodeViewModel, EmployerPutDotBarcodeViewModel, EmployerDeleteDotBarcodeViewModel, EmployerGetsDotBarcodeViewModel)
                    
        {
            _EmployerPostDotBarcodeViewModel = EmployerPostDotBarcodeViewModel;
            _EmployerPutDotBarcodeViewModel = EmployerPutDotBarcodeViewModel;
            _EmployerDeleteDotBarcodeViewModel = EmployerDeleteDotBarcodeViewModel;
            _EmployerGetsDotBarcodeViewModel = EmployerGetsDotBarcodeViewModel;
        }
    }
}