﻿using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofEGOC
{
    public class EmployerEGOCPageViewModel : EmployerStatusPageViewModel<EmployerEGOC> 
    {
        public readonly EmployerPostEGOCViewModel _EmployerPostEGOCViewModel;
        public readonly EmployerPutEGOCViewModel _EmployerPutEGOCViewModel;
        public readonly EmployerDeleteEGOCViewModel _EmployerDeleteEGOCViewModel;
        public readonly EmployerGetsEGOCViewModel _EmployerGetsEGOCViewModel;
        public EmployerEGOCPageViewModel(EmployerPostEGOCViewModel EmployerPostEGOCViewModel, 
                                        EmployerPutEGOCViewModel EmployerPutEGOCViewModel,
                                        EmployerDeleteEGOCViewModel EmployerDeleteEGOCViewModel,
                                        EmployerGetsEGOCViewModel EmployerGetsEGOCViewModel)
                :base(EmployerPostEGOCViewModel, EmployerPutEGOCViewModel, EmployerDeleteEGOCViewModel, EmployerGetsEGOCViewModel)
                    
        {
            _EmployerPostEGOCViewModel = EmployerPostEGOCViewModel;
            _EmployerPutEGOCViewModel = EmployerPutEGOCViewModel;
            _EmployerDeleteEGOCViewModel = EmployerDeleteEGOCViewModel;
            _EmployerGetsEGOCViewModel = EmployerGetsEGOCViewModel;
        }
    }
}