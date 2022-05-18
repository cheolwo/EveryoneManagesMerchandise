﻿using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMMCommodity
{
    public class EmployerMMCommodityPageViewModel : StatusPageViewModel<EmployerMMCommodity> 
    {
        public readonly EmployerPostMMCommodityViewModel _EmployerPostMMCommodityViewModel;
        public readonly EmployerPutMMCommodityViewModel _EmployerPutMMCommodityViewModel;
        public readonly EmployerDeleteMMCommodityViewModel _EmployerDeleteMMCommodityViewModel;
        public readonly EmployerGetsMMCommodityViewModel _EmployerGetsMMCommodityViewModel;
        public EmployerMMCommodityPageViewModel(EmployerPostMMCommodityViewModel EmployerPostMMCommodityViewModel, 
                                        EmployerPutMMCommodityViewModel EmployerPutMMCommodityViewModel,
                                        EmployerDeleteMMCommodityViewModel EmployerDeleteMMCommodityViewModel,
                                        EmployerGetsMMCommodityViewModel EmployerGetsMMCommodityViewModel)
                :base(EmployerPostMMCommodityViewModel, EmployerPutMMCommodityViewModel, EmployerDeleteMMCommodityViewModel, EmployerGetsMMCommodityViewModel)
                    
        {
            _EmployerPostMMCommodityViewModel = EmployerPostMMCommodityViewModel;
            _EmployerPutMMCommodityViewModel = EmployerPutMMCommodityViewModel;
            _EmployerDeleteMMCommodityViewModel = EmployerDeleteMMCommodityViewModel;
            _EmployerGetsMMCommodityViewModel = EmployerGetsMMCommodityViewModel;
        }
    }
}