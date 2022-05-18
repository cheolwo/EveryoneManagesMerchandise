﻿using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofMOCommodity
{
    public class PlatformMOCommodityPageViewModel : StatusPageViewModel<PlatformMOCommodity> 
    {
        public readonly PlatformPostMOCommodityViewModel _PlatformPostMOCommodityViewModel;
        public readonly PlatformPutMOCommodityViewModel _PlatformPutMOCommodityViewModel;
        public readonly PlatformDeleteMOCommodityViewModel _PlatformDeleteMOCommodityViewModel;
        public readonly PlatformGetsMOCommodityViewModel _PlatformGetsMOCommodityViewModel;
        public PlatformMOCommodityPageViewModel(PlatformPostMOCommodityViewModel PlatformPostMOCommodityViewModel, 
                                        PlatformPutMOCommodityViewModel PlatformPutMOCommodityViewModel,
                                        PlatformDeleteMOCommodityViewModel PlatformDeleteMOCommodityViewModel,
                                        PlatformGetsMOCommodityViewModel PlatformGetsMOCommodityViewModel)
                :base(PlatformPostMOCommodityViewModel, PlatformPutMOCommodityViewModel, PlatformDeleteMOCommodityViewModel, PlatformGetsMOCommodityViewModel)
                    
        {
            _PlatformPostMOCommodityViewModel = PlatformPostMOCommodityViewModel;
            _PlatformPutMOCommodityViewModel = PlatformPutMOCommodityViewModel;
            _PlatformDeleteMOCommodityViewModel = PlatformDeleteMOCommodityViewModel;
            _PlatformGetsMOCommodityViewModel = PlatformGetsMOCommodityViewModel;
        }
    }
}