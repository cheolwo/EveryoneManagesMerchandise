﻿using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofMOCommodity
{
    public class EmployerMOCommodityPageViewModel : StatusPageViewModel<EmployerMOCommodity> 
    {
        public readonly EmployerPostMOCommodityViewModel _EmployerPostMOCommodityViewModel;
        public readonly EmployerPutMOCommodityViewModel _EmployerPutMOCommodityViewModel;
        public readonly EmployerDeleteMOCommodityViewModel _EmployerDeleteMOCommodityViewModel;
        public readonly EmployerGetsMOCommodityViewModel _EmployerGetsMOCommodityViewModel;
        public EmployerMOCommodityPageViewModel(EmployerPostMOCommodityViewModel EmployerPostMOCommodityViewModel, 
                                        EmployerPutMOCommodityViewModel EmployerPutMOCommodityViewModel,
                                        EmployerDeleteMOCommodityViewModel EmployerDeleteMOCommodityViewModel,
                                        EmployerGetsMOCommodityViewModel EmployerGetsMOCommodityViewModel)
                :base(EmployerPostMOCommodityViewModel, EmployerPutMOCommodityViewModel, EmployerDeleteMOCommodityViewModel, EmployerGetsMOCommodityViewModel)
                    
        {
            _EmployerPostMOCommodityViewModel = EmployerPostMOCommodityViewModel;
            _EmployerPutMOCommodityViewModel = EmployerPutMOCommodityViewModel;
            _EmployerDeleteMOCommodityViewModel = EmployerDeleteMOCommodityViewModel;
            _EmployerGetsMOCommodityViewModel = EmployerGetsMOCommodityViewModel;
        }
    }
}