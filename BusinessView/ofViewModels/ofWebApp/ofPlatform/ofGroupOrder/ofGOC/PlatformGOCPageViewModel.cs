﻿using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOC
{
    public class PlatformGOCPageViewModel : CenterPageViewModel<PlatformGOC> 
    {
        public PlatformGOCPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostGOCViewModel PlatformPostGOCViewModel, 
                                        PlatformPutGOCViewModel PlatformPutGOCViewModel,
                                        PlatformDeleteGOCViewModel PlatformDeleteGOCViewModel,
                                        PlatformGetsGOCViewModel PlatformGetsGOCViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostGOCViewModel, PlatformPutGOCViewModel, PlatformDeleteGOCViewModel, PlatformGetsGOCViewModel)
                    
        {
            
        }
    }
}