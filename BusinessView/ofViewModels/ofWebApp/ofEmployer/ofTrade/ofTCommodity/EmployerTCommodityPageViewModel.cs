﻿using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTCommodity
{
    public class EmployerTCommodityPageViewModel : EmployerCommodityPageViewModel<EmployerTCommodity> 
    {
        public readonly EmployerPostTCommodityViewModel _EmployerPostTCommodityViewModel;
        public readonly EmployerPutTCommodityViewModel _EmployerPutTCommodityViewModel;
        public readonly EmployerDeleteTCommodityViewModel _EmployerDeleteTCommodityViewModel;
        public readonly EmployerGetsTCommodityViewModel _EmployerGetsTCommodityViewModel;
        public EmployerTCommodityPageViewModel(EmployerPostTCommodityViewModel EmployerPostTCommodityViewModel, 
                                        EmployerPutTCommodityViewModel EmployerPutTCommodityViewModel,
                                        EmployerDeleteTCommodityViewModel EmployerDeleteTCommodityViewModel,
                                        EmployerGetsTCommodityViewModel EmployerGetsTCommodityViewModel)
                :base(EmployerPostTCommodityViewModel, EmployerPutTCommodityViewModel, EmployerDeleteTCommodityViewModel, EmployerGetsTCommodityViewModel)
                    
        {
            _EmployerPostTCommodityViewModel = EmployerPostTCommodityViewModel;
            _EmployerPutTCommodityViewModel = EmployerPutTCommodityViewModel;
            _EmployerDeleteTCommodityViewModel = EmployerDeleteTCommodityViewModel;
            _EmployerGetsTCommodityViewModel = EmployerGetsTCommodityViewModel;
        }
    }
}