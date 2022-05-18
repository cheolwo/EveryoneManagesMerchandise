﻿using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofSGOC
{
    public class EmployerSGOCPageViewModel : StatusPageViewModel<EmployerSGOC> 
    {
        public readonly EmployerPostSGOCViewModel _EmployerPostSGOCViewModel;
        public readonly EmployerPutSGOCViewModel _EmployerPutSGOCViewModel;
        public readonly EmployerDeleteSGOCViewModel _EmployerDeleteSGOCViewModel;
        public readonly EmployerGetsSGOCViewModel _EmployerGetsSGOCViewModel;
        public EmployerSGOCPageViewModel(EmployerPostSGOCViewModel EmployerPostSGOCViewModel, 
                                        EmployerPutSGOCViewModel EmployerPutSGOCViewModel,
                                        EmployerDeleteSGOCViewModel EmployerDeleteSGOCViewModel,
                                        EmployerGetsSGOCViewModel EmployerGetsSGOCViewModel)
                :base(EmployerPostSGOCViewModel, EmployerPutSGOCViewModel, EmployerDeleteSGOCViewModel, EmployerGetsSGOCViewModel)
                    
        {
            _EmployerPostSGOCViewModel = EmployerPostSGOCViewModel;
            _EmployerPutSGOCViewModel = EmployerPutSGOCViewModel;
            _EmployerDeleteSGOCViewModel = EmployerDeleteSGOCViewModel;
            _EmployerGetsSGOCViewModel = EmployerGetsSGOCViewModel;
        }
    }
}