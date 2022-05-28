﻿using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofLoadFrame
{
    public class PlatformLoadFramePageViewModel : LoadFramePageViewModel<PlatformLoadFrame> 
    {
        public readonly PlatformPostLoadFrameViewModel _PlatformPostLoadFrameViewModel;
        public readonly PlatformPutLoadFrameViewModel _PlatformPutLoadFrameViewModel;
        public readonly PlatformDeleteLoadFrameViewModel _PlatformDeleteLoadFrameViewModel;
        public readonly PlatformGetsLoadFrameViewModel _PlatformGetsLoadFrameViewModel;

        public PlatformLoadFramePageViewModel(PlatformPostLoadFrameViewModel PlatformPostLoadFrameViewModel, 
                                        PlatformPutLoadFrameViewModel PlatformPutLoadFrameViewModel,
                                        PlatformDeleteLoadFrameViewModel PlatformDeleteLoadFrameViewModel,
                                        PlatformGetsLoadFrameViewModel PlatformGetsLoadFrameViewModel)
                :base(PlatformPostLoadFrameViewModel, PlatformPutLoadFrameViewModel, PlatformDeleteLoadFrameViewModel, PlatformGetsLoadFrameViewModel)
                    
        {
            _PlatformPostLoadFrameViewModel = PlatformPostLoadFrameViewModel;
            _PlatformPutLoadFrameViewModel = PlatformPutLoadFrameViewModel;
            _PlatformDeleteLoadFrameViewModel = PlatformDeleteLoadFrameViewModel;
            _PlatformGetsLoadFrameViewModel = PlatformGetsLoadFrameViewModel;
        }
    }
}