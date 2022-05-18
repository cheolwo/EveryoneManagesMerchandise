﻿using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofETCommodity
{
    public class PlatformETCommodityPageViewModel : StatusPageViewModel<PlatformETCommodity> 
    {
        public readonly PlatformPostETCommodityViewModel _PlatformPostETCommodityViewModel;
        public readonly PlatformPutETCommodityViewModel _PlatformPutETCommodityViewModel;
        public readonly PlatformDeleteETCommodityViewModel _PlatformDeleteETCommodityViewModel;
        public readonly PlatformGetsETCommodityViewModel _PlatformGetsETCommodityViewModel;
        public PlatformETCommodityPageViewModel(PlatformPostETCommodityViewModel PlatformPostETCommodityViewModel, 
                                        PlatformPutETCommodityViewModel PlatformPutETCommodityViewModel,
                                        PlatformDeleteETCommodityViewModel PlatformDeleteETCommodityViewModel,
                                        PlatformGetsETCommodityViewModel PlatformGetsETCommodityViewModel)
                :base(PlatformPostETCommodityViewModel, PlatformPutETCommodityViewModel, PlatformDeleteETCommodityViewModel, PlatformGetsETCommodityViewModel)
                    
        {
            _PlatformPostETCommodityViewModel = PlatformPostETCommodityViewModel;
            _PlatformPutETCommodityViewModel = PlatformPutETCommodityViewModel;
            _PlatformDeleteETCommodityViewModel = PlatformDeleteETCommodityViewModel;
            _PlatformGetsETCommodityViewModel = PlatformGetsETCommodityViewModel;
        }
    }
}