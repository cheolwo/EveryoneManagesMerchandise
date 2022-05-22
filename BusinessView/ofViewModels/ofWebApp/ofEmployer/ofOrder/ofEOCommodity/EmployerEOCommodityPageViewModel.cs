﻿using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofEOCommodity
{
    public class EmployerEOCommodityPageViewModel : EmployerStatusPageViewModel<EmployerEOCommodity> 
    {
        public readonly EmployerPostEOCommodityViewModel _EmployerPostEOCommodityViewModel;
        public readonly EmployerPutEOCommodityViewModel _EmployerPutEOCommodityViewModel;
        public readonly EmployerDeleteEOCommodityViewModel _EmployerDeleteEOCommodityViewModel;
        public readonly EmployerGetsEOCommodityViewModel _EmployerGetsEOCommodityViewModel;
        public EmployerEOCommodityPageViewModel(EmployerPostEOCommodityViewModel EmployerPostEOCommodityViewModel, 
                                        EmployerPutEOCommodityViewModel EmployerPutEOCommodityViewModel,
                                        EmployerDeleteEOCommodityViewModel EmployerDeleteEOCommodityViewModel,
                                        EmployerGetsEOCommodityViewModel EmployerGetsEOCommodityViewModel)
                :base(EmployerPostEOCommodityViewModel, EmployerPutEOCommodityViewModel, EmployerDeleteEOCommodityViewModel, EmployerGetsEOCommodityViewModel)
                    
        {
            _EmployerPostEOCommodityViewModel = EmployerPostEOCommodityViewModel;
            _EmployerPutEOCommodityViewModel = EmployerPutEOCommodityViewModel;
            _EmployerDeleteEOCommodityViewModel = EmployerDeleteEOCommodityViewModel;
            _EmployerGetsEOCommodityViewModel = EmployerGetsEOCommodityViewModel;
        }
    }
}