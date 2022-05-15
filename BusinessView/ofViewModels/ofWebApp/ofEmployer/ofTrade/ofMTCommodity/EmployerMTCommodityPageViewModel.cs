﻿using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofMTCommodity
{
    public class EmployerMTCommodityPageViewModel : StatusPageViewModel<EmployerMTCommodity> 
    {
        public readonly EmployerPostMTCommodityViewModel _EmployerPostMTCommodityViewModel;
        public readonly EmployerPutMTCommodityViewModel _EmployerPutMTCommodityViewModel;
        public readonly EmployerDeleteMTCommodityViewModel _EmployerDeleteMTCommodityViewModel;
        public readonly EmployerGetsMTCommodityViewModel _EmployerGetsMTCommodityViewModel;
        public EmployerMTCommodityPageViewModel(EmployerPostMTCommodityViewModel EmployerPostMTCommodityViewModel, 
                                        EmployerPutMTCommodityViewModel EmployerPutMTCommodityViewModel,
                                        EmployerDeleteMTCommodityViewModel EmployerDeleteMTCommodityViewModel,
                                        EmployerGetsMTCommodityViewModel EmployerGetsMTCommodityViewModel)
                :base(EmployerPostMTCommodityViewModel, EmployerPutMTCommodityViewModel, EmployerDeleteMTCommodityViewModel, EmployerGetsMTCommodityViewModel)
                    
        {
            _EmployerPostMTCommodityViewModel = EmployerPostMTCommodityViewModel;
            _EmployerPutMTCommodityViewModel = EmployerPutMTCommodityViewModel;
            _EmployerDeleteMTCommodityViewModel = EmployerDeleteMTCommodityViewModel;
            _EmployerGetsMTCommodityViewModel = EmployerGetsMTCommodityViewModel;
        }
    }
}